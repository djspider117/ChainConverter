﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace ChainConverter.UWP.Resolvers
{
    public interface IConverterResolver
    {
        string ConverterKey { get; set; }
        ResourceDictionary Source { get; set; }

        IValueConverter Resolve();
    }
}
