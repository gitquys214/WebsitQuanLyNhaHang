using ASMC5.Models;
using System.Collections.Generic;
using ASMC5.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASMC5.Services
{
    public interface ICart
    {
        MonAn Get(int id);
    }
    public class CartSvc : ICart
    {
        private readonly DataContext _context;
        public CartSvc(DataContext context)
        {
            _context = context;
        }
        public MonAn Get(int id)
        {
            MonAn monAn = new MonAn();
            monAn=_context.MonAns.Find(id);
            return monAn;
        }
    }
}
