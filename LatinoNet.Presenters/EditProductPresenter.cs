﻿using LatinoNet.DTOs;
using LatinoNet.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.Presenters
{
    public class EditProductPresenter : IEditProductOutputPort, IPresenter<ProductDTO>
    {
        public ProductDTO Content { get; private set;} 

        public Task Handle(ProductDTO product)
        {
            Content = product;

            return Task.CompletedTask;
        }
    }
}
