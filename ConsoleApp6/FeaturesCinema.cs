using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class FeaturesCinema
    {
        public string FilmTitle { get; set; }
        public decimal TicketPrice { get; }
        public int ViewerCount { get; set; }
        public string Hall { get; }

        public FeaturesCinema(string filmTitle, decimal ticketPrice, int viewerCount, string hall)
        {
            FilmTitle = filmTitle;
            TicketPrice = ticketPrice;
            ViewerCount = viewerCount;
            Hall = hall;
        }

        public string Information =>
            $"Фильм: {FilmTitle}, Цена билета: {TicketPrice}, Кол-во зрителей: {ViewerCount}, Зал: {Hall}";
    }

    class MethodCinema
    {
        private string filmTitle;
        private decimal ticketPrice;
        private int viewerCount;
        private string hall;

        public MethodCinema(string filmTitle, decimal ticketPrice, int viewerCount, string hall)
        {
            this.filmTitle = filmTitle;
            this.ticketPrice = ticketPrice;
            this.viewerCount = viewerCount;
            this.hall = hall;
        }

        public string GetFilmTitle() => filmTitle;
        public void SetFilmTitle(string value) => filmTitle = value;
        public decimal GetTicketPrice() => ticketPrice;
        public int GetViewerCount() => viewerCount;
        public void SetViewerCount(int value) => viewerCount = value;
        public string GetHall() => hall;

        public string GetInformation() =>
            $"Фильм: {filmTitle}, Цена билета: {ticketPrice}, Кол-во зрителей: {viewerCount}, Зал: {hall}";
    }
}
