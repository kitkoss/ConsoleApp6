using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class FeaturesStudent
    {
        public string FIO { get; set; }
        public string GroupNumber { get; }
        public string RecordBookNumber { get; }
        public string SNILS { get; }

        public FeaturesStudent(string fio, string groupNumber, string recordBookNumber, string snils)
        {
            FIO = fio;
            GroupNumber = groupNumber;
            RecordBookNumber = recordBookNumber;
            SNILS = snils;
        }

        public string Information => $"ФИО: {FIO}, Группа: {GroupNumber}, Зачётка: {RecordBookNumber}, СНИЛС: {SNILS}";
    }

    class MethodStudent
    {
        private string fio;
        private string groupNumber;
        private string recordBookNumber;
        private string snils;

        public MethodStudent(string fio, string groupNumber, string recordBookNumber, string snils)
        {
            this.fio = fio;
            this.groupNumber = groupNumber;
            this.recordBookNumber = recordBookNumber;
            this.snils = snils;
        }

        public string GetFIO() => fio;
        public void SetFIO(string value) => fio = value;
        public string GetGroupNumber() => groupNumber;
        public string GetRecordBookNumber() => recordBookNumber;
        public string GetSNILS() => snils;

        public string GetInformation() => $"ФИО: {fio}, Группа: {groupNumber}, Зачётка: {recordBookNumber}, СНИЛС: {snils}";
    }
}
