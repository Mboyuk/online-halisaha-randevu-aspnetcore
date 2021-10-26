using System.Collections.Generic;
using halisahaapp.business.Abstract;
using halisahaapp.data.Abstract;
using halisahaapp.entity;

namespace halisahaapp.business.Concrete
{
    public class HalisahaManager : IHalisahaService
    {
        private IHalisahaRepository _halisahaRepository;
        public HalisahaManager(IHalisahaRepository halisahaRepository)
        {
            this._halisahaRepository = halisahaRepository;
        }

        public void AddComment(Comment comment)
        {
           _halisahaRepository.AddComment(comment);
        }

        public void AddMessage(Message message)
        {
            _halisahaRepository.AddMessage(message);
        }

        public void AddProperty(string name)
        {
            _halisahaRepository.AddProperty(name);
        }

        public void AddPropertyForHalisaha(int halisahaId, string[] selectedProperties)
        {
            _halisahaRepository.AddPropertyForHalisaha( halisahaId,selectedProperties);
        }

        public List<Halisaha> GetAllHalisahaInCity(string city)
        {
           return _halisahaRepository.GetAllHalisahaInCity(city);
        }

        public List<Property> GetAllProperties()
        {
            return _halisahaRepository.GetAllProperties();
        }

        public double GetAvgPoint(int halisahaId)
        {
            return _halisahaRepository.GetAvgPoint(halisahaId);
        }

        public List<Comment> GetComments(int halisahaId, int page, int pageSize)
        {
            return _halisahaRepository.GetComments(halisahaId,page,pageSize);
        }

        public int GetCountComments(int halisahaId)
        {
            return _halisahaRepository.GetCountComments(halisahaId);
        }

        public Halisaha GetHalisaha(string UserId)
        {
            return _halisahaRepository.GetHalisaha(UserId);
        }

        public Halisaha GetHalisahaById(int id)
        {
           return _halisahaRepository.GetHalisahaById(id);
        }

        public int GetHalisahaIdByUserId(string id)
        {
           return _halisahaRepository.GetHalisahaIdByUserId(id);
        }

        public List<string> GetHalisahaImages(int halisahaId)
        {
           return _halisahaRepository.GetHalisahaImages(halisahaId);
        }

        public List<Rezervation> GetHalisahaRezervations(int halisahaId)
        {
            return _halisahaRepository.GetHalisahaRezervations(halisahaId);
        }

        public List<Rezervation> GetPreTransactions(string UserId)
        {
            return _halisahaRepository.GetPreTransactions(UserId);
        }

        public List<HalisahaProperty> GetSelectedProperties(int id)
        {
           return _halisahaRepository.GetSelectedProperties(id);
        }

        public bool GetUserIdByHalisaha(string id)
        {
           return _halisahaRepository.GetUserIdByHalisaha(id);
        }

        public void MakeReservation(Rezervation reservation)
        {
            _halisahaRepository.MakeReservation(reservation);
        }

        public void RegisterHalisaha(Halisaha halisaha)
        {
            
            _halisahaRepository.RegisterHalisaha(halisaha);
        }

        public void UpdateAvgPoint(int halisahaId, double avgPoint)
        {
            _halisahaRepository.UpdateAvgPoint(halisahaId,avgPoint);
        }

        public void UpdateImage(int halisahaId,string randomName)
        {
            _halisahaRepository.UpdateImage(halisahaId,randomName);
        }

        public void UpdateMessage(string UserId, string message)
        {
            _halisahaRepository.UpdateMessage(UserId,message);
        }

        public void UpdatePrice(string UserId, int price)
        {
            _halisahaRepository.UpdatePrice(UserId,price);
        }
    }
}