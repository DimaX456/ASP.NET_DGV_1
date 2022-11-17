using System;
using ASP_NET_DGV_1.Models;

namespace ASP_NET_DGV_1.Abiturient
{
    public class Users
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Полное имя
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Гендер
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// Др
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// Форма обучения
        /// </summary>
        public FormaObychenia FormaObychenia { get; set; }
        /// <summary>
        /// Баллы ЕГЭ по матем
        /// </summary>
        public decimal Matem { get; set; }
        /// <summary>
        /// Баллы ЕГЭ по русскому
        /// </summary>
        public decimal Rus { get; set; }
        /// <summary>
        /// Баллы ЕГЭ по информатике
        /// </summary>
        public decimal Inf { get; set; }
        /// <summary>
        /// Общая сумма баллов
        /// </summary>
        public decimal Sum { get; set; }
        public decimal AvgRate { get; set; }
    }
}
