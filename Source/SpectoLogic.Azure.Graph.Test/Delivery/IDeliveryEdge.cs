﻿using SpectoLogic.Azure.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectoLogic.Azure.Graph.Test.Delivery
{
    public interface IDeliveryEdge : IEdge<IEndpointVertex,IEndpointVertex>
    {
        double weight { get; set; }
    }
}
