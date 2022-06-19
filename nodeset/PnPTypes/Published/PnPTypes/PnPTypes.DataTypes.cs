/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.Di;
using fortiss_Device;

namespace PnPTypes
{
    #region PositionDataType Class
    #if (!OPCUA_EXCLUDE_PositionDataType)
    /// <summary>
    /// A representation of position in cartesian space
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = PnPTypes.Namespaces.PnPTypesXsd)]
    public partial class PositionDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public PositionDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_x = (double)0;
            m_y = (double)0;
            m_z = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "x", IsRequired = false, Order = 1)]
        public double x
        {
            get { return m_x;  }
            set { m_x = value; }
        }

        /// <remarks />
        [DataMember(Name = "y", IsRequired = false, Order = 2)]
        public double y
        {
            get { return m_y;  }
            set { m_y = value; }
        }

        /// <remarks />
        [DataMember(Name = "z", IsRequired = false, Order = 3)]
        public double z
        {
            get { return m_z;  }
            set { m_z = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.PositionDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.PositionDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.PositionDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            encoder.WriteDouble("x", x);
            encoder.WriteDouble("y", y);
            encoder.WriteDouble("z", z);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            x = decoder.ReadDouble("x");
            y = decoder.ReadDouble("y");
            z = decoder.ReadDouble("z");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            PositionDataType value = encodeable as PositionDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_x, value.m_x)) return false;
            if (!Utils.IsEqual(m_y, value.m_y)) return false;
            if (!Utils.IsEqual(m_z, value.m_z)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (PositionDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PositionDataType clone = (PositionDataType)base.MemberwiseClone();

            clone.m_x = (double)Utils.Clone(this.m_x);
            clone.m_y = (double)Utils.Clone(this.m_y);
            clone.m_z = (double)Utils.Clone(this.m_z);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_x;
        private double m_y;
        private double m_z;
        #endregion
    }

    #region PositionDataTypeCollection Class
    /// <summary>
    /// A collection of PositionDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfPositionDataType", Namespace = PnPTypes.Namespaces.PnPTypesXsd, ItemName = "PositionDataType")]
    #if !NET_STANDARD
    public partial class PositionDataTypeCollection : List<PositionDataType>, ICloneable
    #else
    public partial class PositionDataTypeCollection : List<PositionDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public PositionDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public PositionDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public PositionDataTypeCollection(IEnumerable<PositionDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator PositionDataTypeCollection(PositionDataType[] values)
        {
            if (values != null)
            {
                return new PositionDataTypeCollection(values);
            }

            return new PositionDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator PositionDataType[](PositionDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (PositionDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PositionDataTypeCollection clone = new PositionDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PositionDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region RotationDataType Class
    #if (!OPCUA_EXCLUDE_RotationDataType)
    /// <summary>
    /// A representation of rotation in cartesian space
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = PnPTypes.Namespaces.PnPTypesXsd)]
    public partial class RotationDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public RotationDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_r = (double)0;
            m_p = (double)0;
            m_y = (double)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "r", IsRequired = false, Order = 1)]
        public double r
        {
            get { return m_r;  }
            set { m_r = value; }
        }

        /// <remarks />
        [DataMember(Name = "p", IsRequired = false, Order = 2)]
        public double p
        {
            get { return m_p;  }
            set { m_p = value; }
        }

        /// <remarks />
        [DataMember(Name = "y", IsRequired = false, Order = 3)]
        public double y
        {
            get { return m_y;  }
            set { m_y = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.RotationDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.RotationDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.RotationDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            encoder.WriteDouble("r", r);
            encoder.WriteDouble("p", p);
            encoder.WriteDouble("y", y);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            r = decoder.ReadDouble("r");
            p = decoder.ReadDouble("p");
            y = decoder.ReadDouble("y");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            RotationDataType value = encodeable as RotationDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_r, value.m_r)) return false;
            if (!Utils.IsEqual(m_p, value.m_p)) return false;
            if (!Utils.IsEqual(m_y, value.m_y)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (RotationDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            RotationDataType clone = (RotationDataType)base.MemberwiseClone();

            clone.m_r = (double)Utils.Clone(this.m_r);
            clone.m_p = (double)Utils.Clone(this.m_p);
            clone.m_y = (double)Utils.Clone(this.m_y);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_r;
        private double m_p;
        private double m_y;
        #endregion
    }

    #region RotationDataTypeCollection Class
    /// <summary>
    /// A collection of RotationDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfRotationDataType", Namespace = PnPTypes.Namespaces.PnPTypesXsd, ItemName = "RotationDataType")]
    #if !NET_STANDARD
    public partial class RotationDataTypeCollection : List<RotationDataType>, ICloneable
    #else
    public partial class RotationDataTypeCollection : List<RotationDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public RotationDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public RotationDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public RotationDataTypeCollection(IEnumerable<RotationDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator RotationDataTypeCollection(RotationDataType[] values)
        {
            if (values != null)
            {
                return new RotationDataTypeCollection(values);
            }

            return new RotationDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator RotationDataType[](RotationDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (RotationDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            RotationDataTypeCollection clone = new RotationDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((RotationDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PoseDataType Class
    #if (!OPCUA_EXCLUDE_PoseDataType)
    /// <summary>
    /// A representation of pose in cartesian space, composed by position and rotation
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = PnPTypes.Namespaces.PnPTypesXsd)]
    public partial class PoseDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public PoseDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_position = new PositionDataType();
            m_rotation = new RotationDataType();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "Position", IsRequired = false, Order = 1)]
        public PositionDataType Position
        {
            get
            {
                return m_position;
            }

            set
            {
                m_position = value;

                if (value == null)
                {
                    m_position = new PositionDataType();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "Rotation", IsRequired = false, Order = 2)]
        public RotationDataType Rotation
        {
            get
            {
                return m_rotation;
            }

            set
            {
                m_rotation = value;

                if (value == null)
                {
                    m_rotation = new RotationDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.PoseDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.PoseDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.PoseDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            encoder.WriteEncodeable("Position", Position, typeof(PositionDataType));
            encoder.WriteEncodeable("Rotation", Rotation, typeof(RotationDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            Position = (PositionDataType)decoder.ReadEncodeable("Position", typeof(PositionDataType));
            Rotation = (RotationDataType)decoder.ReadEncodeable("Rotation", typeof(RotationDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            PoseDataType value = encodeable as PoseDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_position, value.m_position)) return false;
            if (!Utils.IsEqual(m_rotation, value.m_rotation)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (PoseDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PoseDataType clone = (PoseDataType)base.MemberwiseClone();

            clone.m_position = (PositionDataType)Utils.Clone(this.m_position);
            clone.m_rotation = (RotationDataType)Utils.Clone(this.m_rotation);

            return clone;
        }
        #endregion

        #region Private Fields
        private PositionDataType m_position;
        private RotationDataType m_rotation;
        #endregion
    }

    #region PoseDataTypeCollection Class
    /// <summary>
    /// A collection of PoseDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfPoseDataType", Namespace = PnPTypes.Namespaces.PnPTypesXsd, ItemName = "PoseDataType")]
    #if !NET_STANDARD
    public partial class PoseDataTypeCollection : List<PoseDataType>, ICloneable
    #else
    public partial class PoseDataTypeCollection : List<PoseDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public PoseDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public PoseDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public PoseDataTypeCollection(IEnumerable<PoseDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator PoseDataTypeCollection(PoseDataType[] values)
        {
            if (values != null)
            {
                return new PoseDataTypeCollection(values);
            }

            return new PoseDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator PoseDataType[](PoseDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (PoseDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PoseDataTypeCollection clone = new PoseDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PoseDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region MarkerDataType Class
    #if (!OPCUA_EXCLUDE_MarkerDataType)
    /// <summary>
    /// Contains the elements representing a Fiducial Marker
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = PnPTypes.Namespaces.PnPTypesXsd)]
    public partial class MarkerDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public MarkerDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_id = (uint)0;
            m_size = (float)0;
            m_dictionary = null;
            m_position = new PositionDataType();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Id", IsRequired = false, Order = 1)]
        public uint Id
        {
            get { return m_id;  }
            set { m_id = value; }
        }

        /// <remarks />
        [DataMember(Name = "Size", IsRequired = false, Order = 2)]
        public float Size
        {
            get { return m_size;  }
            set { m_size = value; }
        }

        /// <remarks />
        [DataMember(Name = "Dictionary", IsRequired = false, Order = 3)]
        public string Dictionary
        {
            get { return m_dictionary;  }
            set { m_dictionary = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "Position", IsRequired = false, Order = 4)]
        public PositionDataType Position
        {
            get
            {
                return m_position;
            }

            set
            {
                m_position = value;

                if (value == null)
                {
                    m_position = new PositionDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.MarkerDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.MarkerDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.MarkerDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            encoder.WriteUInt32("Id", Id);
            encoder.WriteFloat("Size", Size);
            encoder.WriteString("Dictionary", Dictionary);
            encoder.WriteEncodeable("Position", Position, typeof(PositionDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            Id = decoder.ReadUInt32("Id");
            Size = decoder.ReadFloat("Size");
            Dictionary = decoder.ReadString("Dictionary");
            Position = (PositionDataType)decoder.ReadEncodeable("Position", typeof(PositionDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            MarkerDataType value = encodeable as MarkerDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_id, value.m_id)) return false;
            if (!Utils.IsEqual(m_size, value.m_size)) return false;
            if (!Utils.IsEqual(m_dictionary, value.m_dictionary)) return false;
            if (!Utils.IsEqual(m_position, value.m_position)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (MarkerDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MarkerDataType clone = (MarkerDataType)base.MemberwiseClone();

            clone.m_id = (uint)Utils.Clone(this.m_id);
            clone.m_size = (float)Utils.Clone(this.m_size);
            clone.m_dictionary = (string)Utils.Clone(this.m_dictionary);
            clone.m_position = (PositionDataType)Utils.Clone(this.m_position);

            return clone;
        }
        #endregion

        #region Private Fields
        private uint m_id;
        private float m_size;
        private string m_dictionary;
        private PositionDataType m_position;
        #endregion
    }

    #region MarkerDataTypeCollection Class
    /// <summary>
    /// A collection of MarkerDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfMarkerDataType", Namespace = PnPTypes.Namespaces.PnPTypesXsd, ItemName = "MarkerDataType")]
    #if !NET_STANDARD
    public partial class MarkerDataTypeCollection : List<MarkerDataType>, ICloneable
    #else
    public partial class MarkerDataTypeCollection : List<MarkerDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public MarkerDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public MarkerDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public MarkerDataTypeCollection(IEnumerable<MarkerDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator MarkerDataTypeCollection(MarkerDataType[] values)
        {
            if (values != null)
            {
                return new MarkerDataTypeCollection(values);
            }

            return new MarkerDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator MarkerDataType[](MarkerDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (MarkerDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MarkerDataTypeCollection clone = new MarkerDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((MarkerDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region MarkerListDataType Class
    #if (!OPCUA_EXCLUDE_MarkerListDataType)
    /// <summary>
    /// Contains the elements representing a Fiducial Marker
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = PnPTypes.Namespaces.PnPTypesXsd)]
    public partial class MarkerListDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public MarkerListDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_markers = new MarkerDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "Markers", IsRequired = false, Order = 1)]
        public MarkerDataTypeCollection Markers
        {
            get
            {
                return m_markers;
            }

            set
            {
                m_markers = value;

                if (value == null)
                {
                    m_markers = new MarkerDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.MarkerListDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.MarkerListDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.MarkerListDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            encoder.WriteEncodeableArray("Markers", Markers.ToArray(), typeof(MarkerDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            Markers = (MarkerDataTypeCollection)decoder.ReadEncodeableArray("Markers", typeof(MarkerDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            MarkerListDataType value = encodeable as MarkerListDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_markers, value.m_markers)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (MarkerListDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MarkerListDataType clone = (MarkerListDataType)base.MemberwiseClone();

            clone.m_markers = (MarkerDataTypeCollection)Utils.Clone(this.m_markers);

            return clone;
        }
        #endregion

        #region Private Fields
        private MarkerDataTypeCollection m_markers;
        #endregion
    }

    #region MarkerListDataTypeCollection Class
    /// <summary>
    /// A collection of MarkerListDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfMarkerListDataType", Namespace = PnPTypes.Namespaces.PnPTypesXsd, ItemName = "MarkerListDataType")]
    #if !NET_STANDARD
    public partial class MarkerListDataTypeCollection : List<MarkerListDataType>, ICloneable
    #else
    public partial class MarkerListDataTypeCollection : List<MarkerListDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public MarkerListDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public MarkerListDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public MarkerListDataTypeCollection(IEnumerable<MarkerListDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator MarkerListDataTypeCollection(MarkerListDataType[] values)
        {
            if (values != null)
            {
                return new MarkerListDataTypeCollection(values);
            }

            return new MarkerListDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator MarkerListDataType[](MarkerListDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (MarkerListDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MarkerListDataTypeCollection clone = new MarkerListDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((MarkerListDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CameraInfoDataType Class
    #if (!OPCUA_EXCLUDE_CameraInfoDataType)
    /// <summary>
    /// Contains the definition of camera callibration parameters
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = PnPTypes.Namespaces.PnPTypesXsd)]
    public partial class CameraInfoDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public CameraInfoDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_distortionCoefficients = new DoubleCollection();
            m_cameraMatrix = new DoubleCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Camera Distortion Coefficients = [k1, k2, p1, p2, k3]
        /// </summary>
        [DataMember(Name = "DistortionCoefficients", IsRequired = false, Order = 1)]
        public DoubleCollection DistortionCoefficients
        {
            get
            {
                return m_distortionCoefficients;
            }

            set
            {
                m_distortionCoefficients = value;

                if (value == null)
                {
                    m_distortionCoefficients = new DoubleCollection();
                }
            }
        }

        /// <summary>
        /// Camera Matrix = [(fx,0,cx), (0,fy,cy), (0,0,1)]
        /// </summary>
        [DataMember(Name = "CameraMatrix", IsRequired = false, Order = 2)]
        public DoubleCollection CameraMatrix
        {
            get
            {
                return m_cameraMatrix;
            }

            set
            {
                m_cameraMatrix = value;

                if (value == null)
                {
                    m_cameraMatrix = new DoubleCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CameraInfoDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CameraInfoDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CameraInfoDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            encoder.WriteDoubleArray("DistortionCoefficients", DistortionCoefficients);
            encoder.WriteDoubleArray("CameraMatrix", CameraMatrix);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(PnPTypes.Namespaces.PnPTypesXsd);

            DistortionCoefficients = decoder.ReadDoubleArray("DistortionCoefficients");
            CameraMatrix = decoder.ReadDoubleArray("CameraMatrix");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CameraInfoDataType value = encodeable as CameraInfoDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_distortionCoefficients, value.m_distortionCoefficients)) return false;
            if (!Utils.IsEqual(m_cameraMatrix, value.m_cameraMatrix)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (CameraInfoDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CameraInfoDataType clone = (CameraInfoDataType)base.MemberwiseClone();

            clone.m_distortionCoefficients = (DoubleCollection)Utils.Clone(this.m_distortionCoefficients);
            clone.m_cameraMatrix = (DoubleCollection)Utils.Clone(this.m_cameraMatrix);

            return clone;
        }
        #endregion

        #region Private Fields
        private DoubleCollection m_distortionCoefficients;
        private DoubleCollection m_cameraMatrix;
        #endregion
    }

    #region CameraInfoDataTypeCollection Class
    /// <summary>
    /// A collection of CameraInfoDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCameraInfoDataType", Namespace = PnPTypes.Namespaces.PnPTypesXsd, ItemName = "CameraInfoDataType")]
    #if !NET_STANDARD
    public partial class CameraInfoDataTypeCollection : List<CameraInfoDataType>, ICloneable
    #else
    public partial class CameraInfoDataTypeCollection : List<CameraInfoDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CameraInfoDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CameraInfoDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CameraInfoDataTypeCollection(IEnumerable<CameraInfoDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CameraInfoDataTypeCollection(CameraInfoDataType[] values)
        {
            if (values != null)
            {
                return new CameraInfoDataTypeCollection(values);
            }

            return new CameraInfoDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CameraInfoDataType[](CameraInfoDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (CameraInfoDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CameraInfoDataTypeCollection clone = new CameraInfoDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CameraInfoDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}