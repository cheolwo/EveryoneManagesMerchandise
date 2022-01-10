﻿using BusinessData;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ofManager.ofGeneric
{
    public enum WhereOptions {Table, Card, DashBoard}
    public interface INavigateFactory<TEntity> where TEntity : Entity
    {
        string NavigateAfterCreate(WhereOptions options);
        string NavigateAfterDelte(WhereOptions options);
        string NavigateAfterUpdate(WhereOptions options);
    }

    public class NavigateFactory<TEntity> : INavigateFactory<TEntity> where TEntity : Entity
    {
        public virtual string NavigateAfterCreate(WhereOptions options)
        {
            return $"/Get/{options.ToString()}";
        }
        public virtual string NavigateAfterDelte(WhereOptions options)
        {
            return $"/Get/{options.ToString()}";
        }
        public virtual string NavigateAfterUpdate(WhereOptions options)
        {
            return $"/Get/{options.ToString()}";
        }
        // string NavigateAfterDetail(WhereOptions options)
        // {
        //     return $"/Get/{options.ToString()}";
        // }
    }
}
