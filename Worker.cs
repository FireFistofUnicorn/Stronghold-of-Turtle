using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Book
{
    struct Worker
    {
        // Id
        public string Id { get; set; }
        // Время
        public string Now { get; set; }
        // Фио
        public string Fio { get; set; }
        // Возраст
        public string Old { get; set; }
        // Рост
        public string Height { get; set; }
        // Дата рождения
        public string DateOfBirthday { get; set; }
        // Место рождения
        public string Place { get; set; }

        public Worker(string Id, string Now, string Fio, string Old, string Height, string DateOfBirthday, string Place)
        {
            this.Id = Id;
            this.Now = Now;
            this.Fio = Fio;
            this.Old = Old;
            this.Height = Height;
            this.DateOfBirthday = DateOfBirthday;
            this.Place = Place;
        }
        public string Print()
        {
            return $"ID:{Id} Now: {Now} Fio: {Fio} Old: {Old} Height: {Height} DateOfBirthday: {DateOfBirthday} Place: {Place}";
        }

    }
}