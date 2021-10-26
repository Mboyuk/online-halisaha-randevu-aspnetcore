using System;
using System.Collections.Generic;
using System.Linq;
using halisahaapp.data.Abstract;
using halisahaapp.entity;
using Microsoft.EntityFrameworkCore;

namespace halisahaapp.data.Concrete.EfCore
{
    public class EfCoreHalisahaRepository : IHalisahaRepository
    {
        public void AddComment(Comment comment)
        {
            using(var context = new HalisahaContext())
            {
                context.Comments.Add(comment);
                context.SaveChanges();
            }
        }

        public void AddMessage(Message message)
        {
            using(var context = new HalisahaContext())
            {
                context.Messages.Add(message);
            }
        }

        public void AddProperty(string name)
        {
            using (var context = new HalisahaContext())
            {
                var p = new Property() { PropertyName = name };
                context.Properties.Add(p);
                context.SaveChanges();
            }
        }

        public void AddPropertyForHalisaha(int halisahaId, string[] selectedProperties)
        {
            using (var context = new HalisahaContext())
            {
             
                List<int> ids = new List<int>();
                foreach (var item in selectedProperties)
                {
                    ids.Add(context.Properties.Where(i => i.PropertyName == item).Select(i => i.Id).FirstOrDefault());
                }
                // int propId = context.Properties.Where(i => i.PropertyName == selectedProperty).Select(i => i.Id).FirstOrDefault();
                var halisahaProp = context.HalisahaProperties.Where(i => i.HalisahaId == halisahaId);
                context.RemoveRange(halisahaProp);

                List<HalisahaProperty> hhh = new List<HalisahaProperty>();
                foreach (var item in ids)
                {
                    var HP = new HalisahaProperty()
                    {
                        HalisahaId = halisahaId,

                        PropertyId = item

                    };
                    hhh.Add(HP);
                }

                context.HalisahaProperties.AddRange(hhh);
                context.SaveChanges();

               
            }
        }

        public List<Halisaha> GetAllHalisahaInCity(string city)
        {
           using(var context = new HalisahaContext())
           {
               return context.Halisahas.Where(x => x.City == city).ToList();
           }
        }

        public List<Property> GetAllProperties()
        {
            using (var context = new HalisahaContext())
            {
                var properties = context.Properties.ToList();
                return properties;
            }
        }

        public double GetAvgPoint(int halisahaId)
        {
            using(var context = new HalisahaContext())
            {
                return context.Comments.Where(i => i.HalisahaId == halisahaId).Average(i => i.point);
            }
        }

        public List<Comment> GetComments(int halisahaId,int page, int pageSize)
        {
           
            using(var context = new HalisahaContext())
            {
               var comments = context.Comments.Where(x => x.HalisahaId == halisahaId).ToList();
               return comments.Skip((page-1)*pageSize).Take(pageSize).ToList();
            }
        }

        public int GetCountComments(int halisahaId)
        {
           using(var context = new HalisahaContext())
           {
               return context.Comments.Where(x => x.HalisahaId == halisahaId).Count();
           }
        }

        public Halisaha GetHalisaha(string UserId)
        {
            using(var context = new HalisahaContext())
            {
                return context.Halisahas.FirstOrDefault(i => i.UserId == UserId);
            }
        }

        public Halisaha GetHalisahaById(int id)
        {
           using(var context = new HalisahaContext())
           {
               return context.Halisahas.Where(x => x.Id == id).FirstOrDefault();
           }
        }

        public int GetHalisahaIdByUserId(string id)
        {
            using (var context = new HalisahaContext())
            {
                var halisahaId = context.Halisahas.Where(i => i.UserId == id).Select(i => i.Id).FirstOrDefault();

                return halisahaId;

            }
        }

        public List<string> GetHalisahaImages(int halisahaId)
        {
            using(var context = new HalisahaContext())
            {
               var a = context.Images.Where(x => x.HalisahaId == halisahaId).Select(x => x.ImageUrl).ToList();
               return a;
            }
        }

        public List<Rezervation> GetHalisahaRezervations(int halisahaId)
        {
            using(var context = new HalisahaContext())
            {
               return context.Rezervations.Where(i => i.HalisahaId == halisahaId).ToList();
            }
        }

        public List<Rezervation> GetPreTransactions(string UserId)
        {
            using(var context = new HalisahaContext())
            {
                return context.Rezervations.Where(x => x.UserId == UserId).ToList();
            }
        }

        public List<HalisahaProperty> GetSelectedProperties(int id)
        {
            using (var context = new HalisahaContext())
            {
                var hp = context.HalisahaProperties.Where(i => i.HalisahaId == id).AsQueryable();
                var a = hp.Include(i => i.Property).ToList();





                return a;
            }
        }

        public bool GetUserIdByHalisaha(string id)
        {
            using (var context = new HalisahaContext())
            {
                var u = context.Halisahas.Where(i => i.UserId == id).FirstOrDefault();
                if (u == null)
                    return false;
            }
            return true;
        }

        public void MakeReservation(Rezervation reservation)
        {
            using(var context = new HalisahaContext())
            {
                context.Rezervations.Add(reservation);
                context.SaveChanges();
            }
        }

        public void RegisterHalisaha(Halisaha halisaha)
        {
            using (var context = new HalisahaContext())
            {
                context.Halisahas.Add(halisaha);
                context.SaveChanges();
            }
        }

        public void UpdateAvgPoint(int halisahaId, double avgPoint)
        {
            using(var context = new HalisahaContext())
            {
                var halisaha = context.Halisahas.Where(x => x.Id == halisahaId).FirstOrDefault();
                if(halisaha!=null)
                {
                    halisaha.AvgPoint = avgPoint;
                    context.SaveChanges();
                }
            }
        }

        public void UpdateImage(int halisahaId,string randomName)
        {
            using(var context = new HalisahaContext())
            {
                var ı = new Image(){
                    HalisahaId = halisahaId,
                    ImageUrl = randomName
                };
                context.Images.Add(ı);
                context.SaveChanges();

                
            }
        }

        public void UpdateMessage(string UserId, string message)
        {
             using(var context = new HalisahaContext())
            {
                var halisaha = context.Halisahas.Where(i => i.UserId == UserId).FirstOrDefault();
                if(halisaha!=null)
                {
                    halisaha.Content=message;
                    context.SaveChanges();
                }
                
            }
        }

        public void UpdatePrice(string UserId, int price)
        {
            using(var context = new HalisahaContext())
            {
                var halisaha = context.Halisahas.Where(i => i.UserId == UserId).FirstOrDefault();
                if(halisaha!=null)
                {
                    halisaha.Price=price;
                    context.SaveChanges();
                }
                
            }
        }
    }
}