using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataApplication.Devices;
using DataApplication.Models;

namespace DataApplication.DataWriter
{
    public class ExcelWriter : IDataWriter
    {
        private SpreadsheetDocument _doc;
        private WorkbookPart _workBook;
        private WorksheetPart _workSheet;
        private OpenXmlReader _reader;
        private OpenXmlWriter _writer;
        private string _fileName;


        public ExcelWriter()
        {

        }

        public ExcelWriter(string fileNameParam)
        {
            _fileName = fileNameParam;
        }


        public int create()
        {
            if( File.Exists(_fileName) )
            {
                return - 1;
            }

            if (_fileName.Length < 3)
            {
                return -1;
            }

            // Create a spreadsheet document by supplying the filepath.
            // By default, AutoSave = true, Editable = true, and Type = xlsx.
            var spreadsheetDocument = SpreadsheetDocument.Create(_fileName, SpreadsheetDocumentType.Workbook);

            // Add a WorkbookPart to the document.
            var workbookpart = spreadsheetDocument.AddWorkbookPart();
            workbookpart.Workbook = new Workbook();

            // Add a WorksheetPart to the WorkbookPart.
            var worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());

            // Add Sheets to the Workbook.
            var sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild<Sheets>(new Sheets());

            // Append a new worksheet and associate it with the workbook.
            var sheet = new Sheet()
            {
                Id = spreadsheetDocument.WorkbookPart.
                GetIdOfPart(worksheetPart),
                SheetId = 1,
                Name = "Sheet1"
            };

            sheets.Append(sheet);
            workbookpart.Workbook.Save();

            // Close the document.
            spreadsheetDocument.Close();
            return 1;
        }

        public int create(string nameParam)
        {
            if (File.Exists(_fileName))
            {
                return -1;
            }

            if (nameParam.Length < 3)
            {
                return -1;
            }

            // Create a spreadsheet document by supplying the filepath.
            // By default, AutoSave = true, Editable = true, and Type = xlsx.
            var spreadsheetDocument = SpreadsheetDocument.Create( nameParam, SpreadsheetDocumentType.Workbook);

            // Add a WorkbookPart to the document.
            var workbookpart = spreadsheetDocument.AddWorkbookPart();
            workbookpart.Workbook = new Workbook();

            // Add a WorksheetPart to the WorkbookPart.
            var worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());

            // Add Sheets to the Workbook.
            var sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild<Sheets>(new Sheets());

            // Append a new worksheet and associate it with the workbook.
            var sheet = new Sheet()
            {
                Id = spreadsheetDocument.WorkbookPart.
                GetIdOfPart(worksheetPart),
                SheetId = 1,
                Name = "Sheet1"
            };

            sheets.Append(sheet);
            workbookpart.Workbook.Save();
            // Close the document.
            spreadsheetDocument.Close();
            return 1;
        }

        public int open()
        {
            int retvalueTemp = 0;
            if (_fileName.Length < 3)
            {
                return -1;
            }
            try
            {
                _doc = SpreadsheetDocument.Open(_fileName, true);
            }
            catch (Exception ee)
            {
                Console.WriteLine("<ExcelWriter>" + ee.Message);
                return -1;
            }

            if (_doc != null)
            {
                _workBook = _doc.WorkbookPart;
                _workSheet = _workBook.WorksheetParts.First();
                _reader = OpenXmlReader.Create(_workSheet);
                retvalueTemp = 1;
            }
            else
            {
                retvalueTemp = -1;
            }
            return retvalueTemp;

        }

        public int open(string nameParam)
        {
            int retvalueTemp = 0;
            try
            {
                _doc = SpreadsheetDocument.Open(nameParam, true);
            }
            catch (Exception ee)
            {
                Console.WriteLine("<ExcelWriter>" + ee.Message);
                return -1;
            }

            if (_doc != null)
            {
                _workBook = _doc.WorkbookPart;
                _workSheet = _workBook.WorksheetParts.First();
                _reader = OpenXmlReader.Create(_workSheet);
                retvalueTemp = 1;
            }
            else
            {
                retvalueTemp = -1;
            }
            return retvalueTemp;
        }

        public int close()
        {
            _reader.Close();
            _reader.Dispose();
            _doc.Close();
            _doc.Dispose();
            _doc = null;
            return 1;
        }

        public int write(List<IWritable> dataList)
        {
            int retvalueTemp = 0;
            if (_doc != null && _workBook != null && _workSheet != null)
            {
                string originalPartId = _workBook.GetIdOfPart(_workSheet);

                WorksheetPart replacementPart = _workBook.AddNewPart<WorksheetPart>();
                string replacementPartId = _workBook.GetIdOfPart(replacementPart);

                _reader = OpenXmlReader.Create(_workSheet);
                _writer = OpenXmlWriter.Create(replacementPart);

                while (_reader.Read())
                {
                    if (_reader.ElementType == typeof(Selection))
                    {
                        continue;
                    }
                    if (_reader.ElementType == typeof(SheetData))
                    {
                        if (_reader.IsStartElement)
                        {
                            _writer.WriteStartElement(_reader);
                            continue;
                        }

                        // append section begins 
                        //_writer.WriteStartElement(new SheetData()); // beginning of sheetdata
                        Row row = new Row();
                        _writer.WriteStartElement(row); // begining of row 
                        for (int col = 0; col < dataList.Count; col++)
                        {
                            Cell cell = new Cell();
                            cell.CellValue = new CellValue(dataList[col].ToString());
                            //cell.DataType = new EnumValue<CellValues>(CellValues.String);
                            _writer.WriteElement(cell);
                        }
                        _writer.WriteEndElement(); // end of row 
                        _writer.WriteEndElement(); // end of sheetdata
                    }
                    else
                    {
                        if (_reader.IsStartElement)
                        {
                            _writer.WriteStartElement(_reader);
                            if (_reader.ElementType == typeof(CellValue))
                            {
                                _writer.WriteString(_reader.GetText());
                            }
                        }
                        else if (_reader.IsEndElement)
                        {
                            _writer.WriteEndElement();
                        }
                        else
                        {

                        }
                    }
                }

                _writer.Close();
                _reader.Close();

                Sheet sheet = _workBook.Workbook.Descendants<Sheet>().Where(s => s.Id.Value.Equals(originalPartId)).First();
                sheet.Id.Value = replacementPartId;
                _workBook.DeletePart(_workSheet);

            }
            else
            {
                retvalueTemp = -1;
            }
            return retvalueTemp;
        }

        public int write(List<List<IWritable>> dataList)
        {
            int retvalueTemp = 0;
            if (_doc != null && _workBook != null && _workSheet != null)
            {
                string originalPartId = _workBook.GetIdOfPart(_workSheet);

                WorksheetPart replacementPart = _workBook.AddNewPart<WorksheetPart>();
                string replacementPartId = _workBook.GetIdOfPart(replacementPart);

                _reader = OpenXmlReader.Create(_workSheet);
                _writer = OpenXmlWriter.Create(replacementPart);

                while (_reader.Read())
                {
                    if (_reader.ElementType == typeof(Selection))
                    {
                        continue;
                    }
                    if (_reader.ElementType == typeof(SheetData))
                    {
                        if (_reader.IsStartElement)
                        {
                            _writer.WriteStartElement(_reader);
                            continue;
                        }

                        // append section begins 
                        //_writer.WriteStartElement(new SheetData()); // beginning of sheetdata
                        for( int rowIndex = 0; rowIndex < dataList.Count; rowIndex++ )
                        {
                            Row row = new Row();
                            _writer.WriteStartElement(row); // begining of row 
                            for (int colIndex = 0; colIndex < dataList.Count; colIndex++)
                            {
                                Cell cell = new Cell();
                                cell.CellValue = new CellValue(dataList[rowIndex][colIndex].ToString());
                                _writer.WriteElement(cell);
                            }
                            _writer.WriteEndElement(); // end of row 
                        }
                        _writer.WriteEndElement(); // end of sheetdata
                    }
                    else
                    {
                        if (_reader.IsStartElement)
                        {
                            _writer.WriteStartElement(_reader);
                            if (_reader.ElementType == typeof(CellValue))
                            {
                                _writer.WriteString(_reader.GetText());
                            }
                        }
                        else if (_reader.IsEndElement)
                        {
                            _writer.WriteEndElement();
                        }
                        else
                        {

                        }
                    }
                }

                _writer.Close();
                _reader.Close();

                Sheet sheet = _workBook.Workbook.Descendants<Sheet>().Where(s => s.Id.Value.Equals(originalPartId)).First();
                sheet.Id.Value = replacementPartId;
                _workBook.DeletePart(_workSheet);
                
            }
            else
            {
                retvalueTemp = -1;
            }
            return retvalueTemp;
        }

        public int writerHeader(List<ChannelModel> channels, OperatorModel operatorParam, FacilityModel facilityParam)
        {
            throw new NotImplementedException();
        }
    }
}
