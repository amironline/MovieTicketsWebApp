﻿using MovieShop.Domain.DomainModels;
using MovieShop.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieShop.Services.Interface
{
    public interface ITicketService
    {
        List<Ticket> GetAllTickets();
        List<Ticket> GetValidTickets();
        Ticket GetDetailsForTicket(Guid? id);
        void CreateNewTicket(Ticket t);
        void UpdeteExistingTicket(Ticket t);
        AddToShoppingCartDto GetShoppingCartInfo(Guid? id);
        void DeleteTicket(Guid id);
        bool AddToShoppingCart(AddToShoppingCartDto item, string userID);
    }
}
