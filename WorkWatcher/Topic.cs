﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WorkWatcher
{
    public class Topic
    {
        #region Members

        /// <summary>
        /// The name of the topic. This must be unique. Uniqueness
        /// will be checked on form before adding the topic.
        /// </summary>
        private string itsName;

        /// <summary>
        /// A colour to associate with the topic, for use later on e.g.
        /// when drawing a pie chart/line graph, and for colour coding
        /// columsn or rows. Does not need to be unique.
        /// </summary>
        private System.Drawing.Color itsColour;

        /// <summary>
        /// A short (optional) description of the topic. 
        /// </summary>
        private string itsDescription;

        #endregion

        #region Constructor

        public Topic(string name, System.Drawing.Color colour, string description)
        {
            itsName = name;
            itsColour = colour;
            itsDescription = description;
        }

        #endregion

        #region Properties

        public string Name
        {
            get
            {
                return itsName;
            }
            set
            {
                itsName = value;
            }
        }

        public string Description
        {
            get
            {
                return itsDescription;
            }
            set
            {
                itsDescription = value;
            }
        }

        public System.Drawing.Color Colour
        {
            get
            {
                return itsColour;
            }
        }

        #endregion

        #region Internal Methods

        internal void WriteXML(XmlWriter writer)
        {
            writer.WriteStartElement("task");
            {
                writer.WriteAttributeString("name", this.Name);
                writer.WriteAttributeString("colour", this.Colour.ToArgb().ToString());
                writer.WriteAttributeString("description", this.Description);
            }
            writer.WriteEndElement();
        }

        #endregion

    }
}
