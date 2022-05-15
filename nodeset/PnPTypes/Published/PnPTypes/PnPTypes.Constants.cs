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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.Di;
using fortiss_Device;

namespace PnPTypes
{
    #region DataType Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <summary>
        /// The identifier for the HeaderDataType DataType.
        /// </summary>
        public const uint HeaderDataType = 15015;

        /// <summary>
        /// The identifier for the ImageDataType DataType.
        /// </summary>
        public const uint ImageDataType = 15003;

        /// <summary>
        /// The identifier for the PoseDataType DataType.
        /// </summary>
        public const uint PoseDataType = 15005;

        /// <summary>
        /// The identifier for the MarkerDataType DataType.
        /// </summary>
        public const uint MarkerDataType = 15001;

        /// <summary>
        /// The identifier for the MarkerParametersDataType DataType.
        /// </summary>
        public const uint MarkerParametersDataType = 15063;

        /// <summary>
        /// The identifier for the CameraInfoDataType DataType.
        /// </summary>
        public const uint CameraInfoDataType = 15053;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the ICameraInfoParameterType_ParameterSet Object.
        /// </summary>
        public const uint ICameraInfoParameterType_ParameterSet = 15012;

        /// <summary>
        /// The identifier for the HeaderDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint HeaderDataType_Encoding_DefaultBinary = 15019;

        /// <summary>
        /// The identifier for the ImageDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint ImageDataType_Encoding_DefaultBinary = 15004;

        /// <summary>
        /// The identifier for the PoseDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint PoseDataType_Encoding_DefaultBinary = 15017;

        /// <summary>
        /// The identifier for the MarkerDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint MarkerDataType_Encoding_DefaultBinary = 15002;

        /// <summary>
        /// The identifier for the MarkerParametersDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint MarkerParametersDataType_Encoding_DefaultBinary = 15064;

        /// <summary>
        /// The identifier for the CameraInfoDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint CameraInfoDataType_Encoding_DefaultBinary = 15054;

        /// <summary>
        /// The identifier for the HeaderDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint HeaderDataType_Encoding_DefaultXml = 15027;

        /// <summary>
        /// The identifier for the ImageDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint ImageDataType_Encoding_DefaultXml = 15042;

        /// <summary>
        /// The identifier for the PoseDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint PoseDataType_Encoding_DefaultXml = 15043;

        /// <summary>
        /// The identifier for the MarkerDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint MarkerDataType_Encoding_DefaultXml = 15009;

        /// <summary>
        /// The identifier for the MarkerParametersDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint MarkerParametersDataType_Encoding_DefaultXml = 15068;

        /// <summary>
        /// The identifier for the CameraInfoDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint CameraInfoDataType_Encoding_DefaultXml = 15058;

        /// <summary>
        /// The identifier for the HeaderDataType_Encoding_DefaultJson Object.
        /// </summary>
        public const uint HeaderDataType_Encoding_DefaultJson = 15035;

        /// <summary>
        /// The identifier for the ImageDataType_Encoding_DefaultJson Object.
        /// </summary>
        public const uint ImageDataType_Encoding_DefaultJson = 15050;

        /// <summary>
        /// The identifier for the PoseDataType_Encoding_DefaultJson Object.
        /// </summary>
        public const uint PoseDataType_Encoding_DefaultJson = 15051;

        /// <summary>
        /// The identifier for the MarkerDataType_Encoding_DefaultJson Object.
        /// </summary>
        public const uint MarkerDataType_Encoding_DefaultJson = 15052;

        /// <summary>
        /// The identifier for the MarkerParametersDataType_Encoding_DefaultJson Object.
        /// </summary>
        public const uint MarkerParametersDataType_Encoding_DefaultJson = 15072;

        /// <summary>
        /// The identifier for the CameraInfoDataType_Encoding_DefaultJson Object.
        /// </summary>
        public const uint CameraInfoDataType_Encoding_DefaultJson = 15062;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the ICameraInfoParameterType ObjectType.
        /// </summary>
        public const uint ICameraInfoParameterType = 15011;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the ICameraInfoParameterType_ParameterSet_DistortionCoefficients Variable.
        /// </summary>
        public const uint ICameraInfoParameterType_ParameterSet_DistortionCoefficients = 15013;

        /// <summary>
        /// The identifier for the ICameraInfoParameterType_ParameterSet_CameraMatrix Variable.
        /// </summary>
        public const uint ICameraInfoParameterType_ParameterSet_CameraMatrix = 15014;

        /// <summary>
        /// The identifier for the PnPTypes_BinarySchema Variable.
        /// </summary>
        public const uint PnPTypes_BinarySchema = 15020;

        /// <summary>
        /// The identifier for the PnPTypes_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint PnPTypes_BinarySchema_NamespaceUri = 15022;

        /// <summary>
        /// The identifier for the PnPTypes_BinarySchema_Deprecated Variable.
        /// </summary>
        public const uint PnPTypes_BinarySchema_Deprecated = 15023;

        /// <summary>
        /// The identifier for the PnPTypes_BinarySchema_HeaderDataType Variable.
        /// </summary>
        public const uint PnPTypes_BinarySchema_HeaderDataType = 15024;

        /// <summary>
        /// The identifier for the PnPTypes_BinarySchema_ImageDataType Variable.
        /// </summary>
        public const uint PnPTypes_BinarySchema_ImageDataType = 15036;

        /// <summary>
        /// The identifier for the PnPTypes_BinarySchema_PoseDataType Variable.
        /// </summary>
        public const uint PnPTypes_BinarySchema_PoseDataType = 15039;

        /// <summary>
        /// The identifier for the PnPTypes_BinarySchema_MarkerDataType Variable.
        /// </summary>
        public const uint PnPTypes_BinarySchema_MarkerDataType = 15006;

        /// <summary>
        /// The identifier for the PnPTypes_BinarySchema_MarkerParametersDataType Variable.
        /// </summary>
        public const uint PnPTypes_BinarySchema_MarkerParametersDataType = 15065;

        /// <summary>
        /// The identifier for the PnPTypes_BinarySchema_CameraInfoDataType Variable.
        /// </summary>
        public const uint PnPTypes_BinarySchema_CameraInfoDataType = 15055;

        /// <summary>
        /// The identifier for the PnPTypes_XmlSchema Variable.
        /// </summary>
        public const uint PnPTypes_XmlSchema = 15028;

        /// <summary>
        /// The identifier for the PnPTypes_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint PnPTypes_XmlSchema_NamespaceUri = 15030;

        /// <summary>
        /// The identifier for the PnPTypes_XmlSchema_Deprecated Variable.
        /// </summary>
        public const uint PnPTypes_XmlSchema_Deprecated = 15031;

        /// <summary>
        /// The identifier for the PnPTypes_XmlSchema_HeaderDataType Variable.
        /// </summary>
        public const uint PnPTypes_XmlSchema_HeaderDataType = 15032;

        /// <summary>
        /// The identifier for the PnPTypes_XmlSchema_ImageDataType Variable.
        /// </summary>
        public const uint PnPTypes_XmlSchema_ImageDataType = 15044;

        /// <summary>
        /// The identifier for the PnPTypes_XmlSchema_PoseDataType Variable.
        /// </summary>
        public const uint PnPTypes_XmlSchema_PoseDataType = 15047;

        /// <summary>
        /// The identifier for the PnPTypes_XmlSchema_MarkerDataType Variable.
        /// </summary>
        public const uint PnPTypes_XmlSchema_MarkerDataType = 15010;

        /// <summary>
        /// The identifier for the PnPTypes_XmlSchema_MarkerParametersDataType Variable.
        /// </summary>
        public const uint PnPTypes_XmlSchema_MarkerParametersDataType = 15069;

        /// <summary>
        /// The identifier for the PnPTypes_XmlSchema_CameraInfoDataType Variable.
        /// </summary>
        public const uint PnPTypes_XmlSchema_CameraInfoDataType = 15059;
    }
    #endregion

    #region DataType Node Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <summary>
        /// The identifier for the HeaderDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId HeaderDataType = new ExpandedNodeId(PnPTypes.DataTypes.HeaderDataType, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the ImageDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ImageDataType = new ExpandedNodeId(PnPTypes.DataTypes.ImageDataType, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PoseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId PoseDataType = new ExpandedNodeId(PnPTypes.DataTypes.PoseDataType, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the MarkerDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDataType = new ExpandedNodeId(PnPTypes.DataTypes.MarkerDataType, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the MarkerParametersDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId MarkerParametersDataType = new ExpandedNodeId(PnPTypes.DataTypes.MarkerParametersDataType, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the CameraInfoDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId CameraInfoDataType = new ExpandedNodeId(PnPTypes.DataTypes.CameraInfoDataType, PnPTypes.Namespaces.PnPTypes);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the ICameraInfoParameterType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ICameraInfoParameterType_ParameterSet = new ExpandedNodeId(PnPTypes.Objects.ICameraInfoParameterType_ParameterSet, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the HeaderDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId HeaderDataType_Encoding_DefaultBinary = new ExpandedNodeId(PnPTypes.Objects.HeaderDataType_Encoding_DefaultBinary, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the ImageDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ImageDataType_Encoding_DefaultBinary = new ExpandedNodeId(PnPTypes.Objects.ImageDataType_Encoding_DefaultBinary, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PoseDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId PoseDataType_Encoding_DefaultBinary = new ExpandedNodeId(PnPTypes.Objects.PoseDataType_Encoding_DefaultBinary, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the MarkerDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDataType_Encoding_DefaultBinary = new ExpandedNodeId(PnPTypes.Objects.MarkerDataType_Encoding_DefaultBinary, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the MarkerParametersDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId MarkerParametersDataType_Encoding_DefaultBinary = new ExpandedNodeId(PnPTypes.Objects.MarkerParametersDataType_Encoding_DefaultBinary, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the CameraInfoDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId CameraInfoDataType_Encoding_DefaultBinary = new ExpandedNodeId(PnPTypes.Objects.CameraInfoDataType_Encoding_DefaultBinary, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the HeaderDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId HeaderDataType_Encoding_DefaultXml = new ExpandedNodeId(PnPTypes.Objects.HeaderDataType_Encoding_DefaultXml, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the ImageDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ImageDataType_Encoding_DefaultXml = new ExpandedNodeId(PnPTypes.Objects.ImageDataType_Encoding_DefaultXml, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PoseDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId PoseDataType_Encoding_DefaultXml = new ExpandedNodeId(PnPTypes.Objects.PoseDataType_Encoding_DefaultXml, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the MarkerDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDataType_Encoding_DefaultXml = new ExpandedNodeId(PnPTypes.Objects.MarkerDataType_Encoding_DefaultXml, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the MarkerParametersDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId MarkerParametersDataType_Encoding_DefaultXml = new ExpandedNodeId(PnPTypes.Objects.MarkerParametersDataType_Encoding_DefaultXml, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the CameraInfoDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId CameraInfoDataType_Encoding_DefaultXml = new ExpandedNodeId(PnPTypes.Objects.CameraInfoDataType_Encoding_DefaultXml, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the HeaderDataType_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId HeaderDataType_Encoding_DefaultJson = new ExpandedNodeId(PnPTypes.Objects.HeaderDataType_Encoding_DefaultJson, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the ImageDataType_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId ImageDataType_Encoding_DefaultJson = new ExpandedNodeId(PnPTypes.Objects.ImageDataType_Encoding_DefaultJson, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PoseDataType_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId PoseDataType_Encoding_DefaultJson = new ExpandedNodeId(PnPTypes.Objects.PoseDataType_Encoding_DefaultJson, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the MarkerDataType_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDataType_Encoding_DefaultJson = new ExpandedNodeId(PnPTypes.Objects.MarkerDataType_Encoding_DefaultJson, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the MarkerParametersDataType_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId MarkerParametersDataType_Encoding_DefaultJson = new ExpandedNodeId(PnPTypes.Objects.MarkerParametersDataType_Encoding_DefaultJson, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the CameraInfoDataType_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId CameraInfoDataType_Encoding_DefaultJson = new ExpandedNodeId(PnPTypes.Objects.CameraInfoDataType_Encoding_DefaultJson, PnPTypes.Namespaces.PnPTypes);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the ICameraInfoParameterType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ICameraInfoParameterType = new ExpandedNodeId(PnPTypes.ObjectTypes.ICameraInfoParameterType, PnPTypes.Namespaces.PnPTypes);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the ICameraInfoParameterType_ParameterSet_DistortionCoefficients Variable.
        /// </summary>
        public static readonly ExpandedNodeId ICameraInfoParameterType_ParameterSet_DistortionCoefficients = new ExpandedNodeId(PnPTypes.Variables.ICameraInfoParameterType_ParameterSet_DistortionCoefficients, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the ICameraInfoParameterType_ParameterSet_CameraMatrix Variable.
        /// </summary>
        public static readonly ExpandedNodeId ICameraInfoParameterType_ParameterSet_CameraMatrix = new ExpandedNodeId(PnPTypes.Variables.ICameraInfoParameterType_ParameterSet_CameraMatrix, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PnPTypes_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId PnPTypes_BinarySchema = new ExpandedNodeId(PnPTypes.Variables.PnPTypes_BinarySchema, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PnPTypes_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId PnPTypes_BinarySchema_NamespaceUri = new ExpandedNodeId(PnPTypes.Variables.PnPTypes_BinarySchema_NamespaceUri, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PnPTypes_BinarySchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId PnPTypes_BinarySchema_Deprecated = new ExpandedNodeId(PnPTypes.Variables.PnPTypes_BinarySchema_Deprecated, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PnPTypes_BinarySchema_HeaderDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId PnPTypes_BinarySchema_HeaderDataType = new ExpandedNodeId(PnPTypes.Variables.PnPTypes_BinarySchema_HeaderDataType, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PnPTypes_BinarySchema_ImageDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId PnPTypes_BinarySchema_ImageDataType = new ExpandedNodeId(PnPTypes.Variables.PnPTypes_BinarySchema_ImageDataType, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PnPTypes_BinarySchema_PoseDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId PnPTypes_BinarySchema_PoseDataType = new ExpandedNodeId(PnPTypes.Variables.PnPTypes_BinarySchema_PoseDataType, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PnPTypes_BinarySchema_MarkerDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId PnPTypes_BinarySchema_MarkerDataType = new ExpandedNodeId(PnPTypes.Variables.PnPTypes_BinarySchema_MarkerDataType, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PnPTypes_BinarySchema_MarkerParametersDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId PnPTypes_BinarySchema_MarkerParametersDataType = new ExpandedNodeId(PnPTypes.Variables.PnPTypes_BinarySchema_MarkerParametersDataType, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PnPTypes_BinarySchema_CameraInfoDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId PnPTypes_BinarySchema_CameraInfoDataType = new ExpandedNodeId(PnPTypes.Variables.PnPTypes_BinarySchema_CameraInfoDataType, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PnPTypes_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId PnPTypes_XmlSchema = new ExpandedNodeId(PnPTypes.Variables.PnPTypes_XmlSchema, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PnPTypes_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId PnPTypes_XmlSchema_NamespaceUri = new ExpandedNodeId(PnPTypes.Variables.PnPTypes_XmlSchema_NamespaceUri, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PnPTypes_XmlSchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId PnPTypes_XmlSchema_Deprecated = new ExpandedNodeId(PnPTypes.Variables.PnPTypes_XmlSchema_Deprecated, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PnPTypes_XmlSchema_HeaderDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId PnPTypes_XmlSchema_HeaderDataType = new ExpandedNodeId(PnPTypes.Variables.PnPTypes_XmlSchema_HeaderDataType, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PnPTypes_XmlSchema_ImageDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId PnPTypes_XmlSchema_ImageDataType = new ExpandedNodeId(PnPTypes.Variables.PnPTypes_XmlSchema_ImageDataType, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PnPTypes_XmlSchema_PoseDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId PnPTypes_XmlSchema_PoseDataType = new ExpandedNodeId(PnPTypes.Variables.PnPTypes_XmlSchema_PoseDataType, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PnPTypes_XmlSchema_MarkerDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId PnPTypes_XmlSchema_MarkerDataType = new ExpandedNodeId(PnPTypes.Variables.PnPTypes_XmlSchema_MarkerDataType, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PnPTypes_XmlSchema_MarkerParametersDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId PnPTypes_XmlSchema_MarkerParametersDataType = new ExpandedNodeId(PnPTypes.Variables.PnPTypes_XmlSchema_MarkerParametersDataType, PnPTypes.Namespaces.PnPTypes);

        /// <summary>
        /// The identifier for the PnPTypes_XmlSchema_CameraInfoDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId PnPTypes_XmlSchema_CameraInfoDataType = new ExpandedNodeId(PnPTypes.Variables.PnPTypes_XmlSchema_CameraInfoDataType, PnPTypes.Namespaces.PnPTypes);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the CameraInfoDataType component.
        /// </summary>
        public const string CameraInfoDataType = "CameraInfoDataType";

        /// <summary>
        /// The BrowseName for the HeaderDataType component.
        /// </summary>
        public const string HeaderDataType = "HeaderDataType";

        /// <summary>
        /// The BrowseName for the ICameraInfoParameterType component.
        /// </summary>
        public const string ICameraInfoParameterType = "ICameraInfoParameterType";

        /// <summary>
        /// The BrowseName for the ImageDataType component.
        /// </summary>
        public const string ImageDataType = "ImageDataType";

        /// <summary>
        /// The BrowseName for the MarkerDataType component.
        /// </summary>
        public const string MarkerDataType = "MarkerDataType";

        /// <summary>
        /// The BrowseName for the MarkerParametersDataType component.
        /// </summary>
        public const string MarkerParametersDataType = "MarkerParametersDataType";

        /// <summary>
        /// The BrowseName for the PnPTypes_BinarySchema component.
        /// </summary>
        public const string PnPTypes_BinarySchema = "PnPTypes";

        /// <summary>
        /// The BrowseName for the PnPTypes_XmlSchema component.
        /// </summary>
        public const string PnPTypes_XmlSchema = "PnPTypes";

        /// <summary>
        /// The BrowseName for the PoseDataType component.
        /// </summary>
        public const string PoseDataType = "PoseDataType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the PnPTypes namespace (.NET code namespace is 'PnPTypes').
        /// </summary>
        public const string PnPTypes = "https://pnp.org/UA/PnPTypes/";

        /// <summary>
        /// The URI for the PnPTypesXsd namespace (.NET code namespace is 'PnPTypes').
        /// </summary>
        public const string PnPTypesXsd = "https://pnp.org/UA/PnPTypes/Types.xsd";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the OpcUaDi namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDi = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the OpcUaDiXsd namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDiXsd = "http://opcfoundation.org/UA/DI/Types.xsd";

        /// <summary>
        /// The URI for the fortissDevice namespace (.NET code namespace is 'fortiss_Device').
        /// </summary>
        public const string fortissDevice = "https://fortiss.org/UA/Device/";

        /// <summary>
        /// The URI for the fortissDeviceXsd namespace (.NET code namespace is 'fortiss_Device').
        /// </summary>
        public const string fortissDeviceXsd = "https://fortiss.org/UA/Device/Types.xsd";
    }
    #endregion
}