using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static Templates.Classes.Task2_3;

namespace Templates.Classes
{
    internal class Task2_1
    {
        public char[] GetData(DateTime dateTime)
        {
            string sDateTime = dateTime.ToString("d").Replace(".", "");
            char[] chDateTime = sDateTime.ToArray();
            return chDateTime;
        }
    }
    internal class Task2_2
    {
        public char[] GetData(string documentSeries, string documentNumber, bool isINN)
        {
            string passdoc = new string(' ', 20);
            if (isINN)
                return passdoc.ToArray();
            passdoc = (documentSeries + documentNumber).PadRight(20, '-');
            return passdoc.ToArray();
        }
    }
    internal class Task2_3
    {
        internal struct Doc
        {
            internal string DocumentTypeNCode;
            internal string DocumentTypeCode;
            internal string DocumentTypeName;
        }
        public char[] GetData(string documentTypeCode, string documentTypeName)
        {
            List<Doc> docs = new List<Doc>();
            docs.Add(new Doc() { DocumentTypeNCode = "21", DocumentTypeCode = "ПАСГРАРФ", DocumentTypeName = "Паспорт гражданина РФ" });
            docs.Add(new Doc() { DocumentTypeNCode = "03", DocumentTypeCode = "СВИРОЖ", DocumentTypeName = "Свидетельство о рождении гражданина РФ" });
            docs.Add(new Doc() { DocumentTypeNCode = "12", DocumentTypeCode = "ВИДЖИТ", DocumentTypeName = "Вид на жительство" });
            docs.Add(new Doc() { DocumentTypeNCode = "10", DocumentTypeCode = "ИНОПАС", DocumentTypeName = "Паспорт иностранного гражданина" });
            docs.Add(new Doc() { DocumentTypeNCode = "14", DocumentTypeCode = "ВРУДОРФ", DocumentTypeName = "Временное удостоверение РФ" });
            var documentTypeNCode = (from doc in docs.
                                     Where(doc => doc.DocumentTypeCode == documentTypeCode &&
                                     doc.DocumentTypeName == documentTypeName)
                                     select doc.DocumentTypeNCode).FirstOrDefault();
            return documentTypeNCode.ToArray();
        }
    }
}
