﻿using BusinessData.ofPresendationLayer.ofDTOServices;
using BusinessView.ofCommon.ofServices;

namespace BusinessView.ofUser.ofCommon
{
    public class ServiceBuilder
    {
        private Dictionary<int, DTOService> DicViewService { get; set; }
        public ServiceBuilder()
        {
            DicViewService = new();
        }
        // Using // Actor : virtual void OnConfigureViewService(ServiceBuilder serviceBuilder)
        public void Add(string nameofDTO, DTOService viewService)
        {
            DicViewService.Add(nameofDTO.GetHashCode(), viewService);
        }
        // Using // Actor : virtaul Add<T> (T t) where T : IViewModel
        // This Method Purpose is to Get ViewService In Dictionay of ViewServices
        public DTOService Get(string nameofDTO)
        {
            return DicViewService[nameofDTO.GetHashCode()]
                   ?? throw new ArgumentNullException("Not Include ViewService For ViewModel");
        }
    }
}
