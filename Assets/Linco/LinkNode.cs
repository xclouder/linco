using System;
using System.Globalization;

namespace Linco
{
    public class LinkNode<T> : ILinkNode<T>
    {
        private Object preNode;
        
        public ILinkNode<TOutput> Append<TOutput>(ICompute<T, TOutput> compute)
        {
            var nextNode = new LinkNode<TOutput>();
            
            
            return nextNode;
        }

        public IDisposable Run()
        {
            if (preNode == null)
            {
                //todo execute 
            }
            else
            {
                //todo
                //preNode.Run();
            }

            return null;
        }

        private class InnerLink<T1, T2>
        {
            public InnerLink()
            {
                
            }
        }
    }
    
    
}