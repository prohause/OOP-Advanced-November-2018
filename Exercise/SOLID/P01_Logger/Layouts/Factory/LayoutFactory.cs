using System;

namespace P01_Logger.Layouts.Factory
{
    using Contracts;
    using Layouts.Contracts;

    public class LayoutFactory : ILayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            var typeAsLowerCase = type.ToLower();

            switch (typeAsLowerCase)
            {
                case "simplelayout":
                    return new SimpleLayout();

                case "xmllayout":
                    return new XmlLayout();

                default:
                    throw new ArgumentException("Invalid layout type!");
            }
        }
    }
}