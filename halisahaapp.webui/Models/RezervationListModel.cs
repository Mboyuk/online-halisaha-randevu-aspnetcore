using System;
using System.Collections.Generic;
using halisahaapp.entity;

namespace halisahaapp.webui.Models
{
    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public string CurrentCategory { get; set; }

        public int TotalPages()
        {
             return (int)Math.Ceiling((decimal)TotalItems/ItemsPerPage);
        }
    }
    public class RezervationListModel
    {

        public PageInfo PageInfo { get; set; }
        public CommentModel CommentModel {get;set;}
        public List<Rezervation> Rezervations { get; set; }
         public IEnumerable<string> SelectedProperties{ get; set; }
    }
}