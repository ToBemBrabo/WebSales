﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSales.Models;

namespace WebSales.Data
{
    public class DepartmentService
    {
        private readonly WebSalesContext _context;

        public DepartmentService(WebSalesContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

    }
}
