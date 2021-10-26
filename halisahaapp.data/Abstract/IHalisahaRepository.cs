using System.Collections.Generic;
using halisahaapp.entity;

namespace halisahaapp.data.Abstract
{
    public interface IHalisahaRepository
    {
        void RegisterHalisaha(Halisaha halisaha);
        bool GetUserIdByHalisaha(string id);
        void AddProperty(string name);
        List<Property> GetAllProperties();
        List<HalisahaProperty> GetSelectedProperties(int id);
        int GetHalisahaIdByUserId(string id);
        void AddPropertyForHalisaha(int halisahaId, string[] selectedProperties);
        Halisaha GetHalisaha(string UserId);
        void UpdatePrice(string UserId,int price);
        void UpdateMessage(string UserId,string message);
        void UpdateImage(int halisahaId, string randomName);
        List<Rezervation> GetHalisahaRezervations(int halisahaId);
        Halisaha GetHalisahaById(int id);
        void MakeReservation(Rezervation reservation);
        List<string> GetHalisahaImages(int halisahaId);
        List<Halisaha> GetAllHalisahaInCity(string city);
        List<Rezervation> GetPreTransactions(string UserId);
        void AddComment(Comment comment);
        List<Comment> GetComments(int halisahaId, int page, int pageSize);
        void AddMessage(Message message);
        int GetCountComments(int halisahaId);
        double GetAvgPoint(int halisahaId);
        void UpdateAvgPoint(int halisahaId, double avgPoint);
        
    }
}