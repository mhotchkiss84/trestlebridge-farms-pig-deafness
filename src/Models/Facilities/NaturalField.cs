using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class NaturalField : IFacility<IResource>
    {

        public int Rows { get; set; } = 10;
        public int Plants { get; set; } = 6;
        
        public Double Capacity
        {
            get
            {
                return Rows * Plants;
            }
        } 

        public void AddResource (IGrazing animal)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public void AddResource (List<IGrazing> animals) 
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public void AddResource(List<ICompostProducing> plants)
        {
            throw new NotImplementedException();
        }

        internal void AddResource(ICompostProducing resource)
        {
            throw new NotImplementedException();
        }
    }
}