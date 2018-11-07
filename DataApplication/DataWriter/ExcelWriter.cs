using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.DataWriter
{
    public class ExcelWriter : IDataWriter
    {
        private SpreadsheetDocument _doc;
        private WorkbookPart _workBook;
        private WorksheetPart _workSheet;
        private OpenXmlReader _reader;
        private OpenXmlWriter _writer;
    

        public int open( string nameParam)
        {
            int retvalueTemp = 0;
            try
            {
                _doc = SpreadsheetDocument.Open(nameParam, true);
            }
            catch(Exception ee)
            {
                Console.WriteLine("<ExcelWriter>" +  ee.Message);
                return -1;
            }
            
            if(_doc != null )
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
            bool sheetDataSectionActive = false;
            if( _doc != null && _workBook != null && _workSheet != null )
            {
                string originalPartId = _workBook.GetIdOfPart(_workSheet);

                WorksheetPart replacementPart = _workBook.AddNewPart<WorksheetPart>();
                string replacementPartId = _workBook.GetIdOfPart(replacementPart);

                _reader = OpenXmlReader.Create(_workSheet);
                _writer = OpenXmlWriter.Create(replacementPart);

                
                
                while(_reader.Read())
                {
                    if(_reader.ElementType == typeof(Selection))
                    {
                        continue;
                    }
                    if( _reader.ElementType == typeof(SheetData))
                    {
                        if( _reader.IsStartElement )
                        {
                            sheetDataSectionActive = true;
                            _writer.WriteStartElement(_reader);
                            continue;
                        }
                        if (_reader.IsEndElement)
                        {
                            sheetDataSectionActive = false;
                        }
                        // append section begins 
                        //_writer.WriteStartElement(new SheetData()); // beginning of sheetdata
                        Row row = new Row();
                        _writer.WriteStartElement(row); // begining of row 
                        for(int col = 0; col < dataList.Count; col++ )
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
                        if(_reader.IsStartElement)
                        {
                            _writer.WriteStartElement(_reader);
                            if (_reader.ElementType == typeof(CellValue))
                            {
                                //Console.WriteLine(_reader.GetText());
                                _writer.WriteString(_reader.GetText());
                            }
                        }
                        else if(_reader.IsEndElement)
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
                    if (_reader.ElementType == typeof(SheetData))
                    {
                        if (_reader.IsEndElement)
                            continue;
                        // append section begins 
                        _writer.WriteStartElement(new SheetData());
                        for (int row = 0; row < dataList.Count; row++)
                        {
                            for (int col = 0; col < dataList[row].Count; col++)
                            {

                            }
                        }
                    }
                    else
                    {

                    }
                }

            }
            else
            {
                retvalueTemp = -1;
            }
            return retvalueTemp;
        }
    }

}
