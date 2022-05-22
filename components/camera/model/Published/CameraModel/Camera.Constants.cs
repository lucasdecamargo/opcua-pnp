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
using PnPTypes;

namespace Camera
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_InitLock Method.
        /// </summary>
        public const uint CameraDeviceType_Lock_InitLock = 15083;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_RenewLock Method.
        /// </summary>
        public const uint CameraDeviceType_Lock_RenewLock = 15086;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_ExitLock Method.
        /// </summary>
        public const uint CameraDeviceType_Lock_ExitLock = 15088;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_BreakLock Method.
        /// </summary>
        public const uint CameraDeviceType_Lock_BreakLock = 15090;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_InitLock = 15118;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_RenewLock = 15121;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_ExitLock = 15123;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_BreakLock = 15125;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_InitLock Method.
        /// </summary>
        public const uint CameraDevice_Lock_InitLock = 15153;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_RenewLock Method.
        /// </summary>
        public const uint CameraDevice_Lock_RenewLock = 15156;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_ExitLock Method.
        /// </summary>
        public const uint CameraDevice_Lock_ExitLock = 15158;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_BreakLock Method.
        /// </summary>
        public const uint CameraDevice_Lock_BreakLock = 15160;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_InitLock = 15188;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_RenewLock = 15191;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_ExitLock = 15193;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_BreakLock = 15195;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_Halt Method.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_Halt = 15243;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_Reset Method.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_Reset = 15244;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_Resume Method.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_Resume = 15245;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_Suspend Method.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_Suspend = 15246;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_Start Method.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_Start = 15247;
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
        /// The identifier for the PhotoSkillType_ParameterSet Object.
        /// </summary>
        public const uint PhotoSkillType_ParameterSet = 15068;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_NetworkAddress = 15127;

        /// <summary>
        /// The identifier for the CameraDevice Object.
        /// </summary>
        public const uint CameraDevice = 15139;

        /// <summary>
        /// The identifier for the CameraDevice_ParameterSet Object.
        /// </summary>
        public const uint CameraDevice_ParameterSet = 15140;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_NetworkAddress = 15197;

        /// <summary>
        /// The identifier for the CameraDevice_Skills Object.
        /// </summary>
        public const uint CameraDevice_Skills = 15210;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill Object.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill = 15211;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ParameterSet Object.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_ParameterSet = 15248;
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
        /// The identifier for the PhotoSkillType ObjectType.
        /// </summary>
        public const uint PhotoSkillType = 15001;

        /// <summary>
        /// The identifier for the CameraDeviceType ObjectType.
        /// </summary>
        public const uint CameraDeviceType = 15069;
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
        /// The identifier for the PhotoSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint PhotoSkillType_CurrentState_Id = 15003;

        /// <summary>
        /// The identifier for the PhotoSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint PhotoSkillType_CurrentState_Number = 15005;

        /// <summary>
        /// The identifier for the PhotoSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint PhotoSkillType_LastTransition_Id = 15008;

        /// <summary>
        /// The identifier for the PhotoSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint PhotoSkillType_LastTransition_Number = 15010;

        /// <summary>
        /// The identifier for the PhotoSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint PhotoSkillType_LastTransition_TransitionTime = 15011;

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint PhotoSkillType_ProgramDiagnostic_CreateSessionId = 15023;

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint PhotoSkillType_ProgramDiagnostic_CreateClientName = 15024;

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint PhotoSkillType_ProgramDiagnostic_InvocationCreationTime = 15025;

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint PhotoSkillType_ProgramDiagnostic_LastTransitionTime = 15026;

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint PhotoSkillType_ProgramDiagnostic_LastMethodCall = 15027;

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint PhotoSkillType_ProgramDiagnostic_LastMethodSessionId = 15028;

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint PhotoSkillType_ProgramDiagnostic_LastMethodInputArguments = 15029;

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint PhotoSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15030;

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint PhotoSkillType_ProgramDiagnostic_LastMethodInputValues = 15031;

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint PhotoSkillType_ProgramDiagnostic_LastMethodOutputValues = 15032;

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint PhotoSkillType_ProgramDiagnostic_LastMethodCallTime = 15033;

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint PhotoSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15034;

        /// <summary>
        /// The identifier for the PhotoSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint PhotoSkillType_Halted_StateNumber = 15037;

        /// <summary>
        /// The identifier for the PhotoSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint PhotoSkillType_Ready_StateNumber = 15039;

        /// <summary>
        /// The identifier for the PhotoSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint PhotoSkillType_Running_StateNumber = 15041;

        /// <summary>
        /// The identifier for the PhotoSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint PhotoSkillType_Suspended_StateNumber = 15043;

        /// <summary>
        /// The identifier for the PhotoSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint PhotoSkillType_HaltedToReady_TransitionNumber = 15045;

        /// <summary>
        /// The identifier for the PhotoSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint PhotoSkillType_ReadyToRunning_TransitionNumber = 15047;

        /// <summary>
        /// The identifier for the PhotoSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint PhotoSkillType_RunningToHalted_TransitionNumber = 15049;

        /// <summary>
        /// The identifier for the PhotoSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint PhotoSkillType_RunningToReady_TransitionNumber = 15051;

        /// <summary>
        /// The identifier for the PhotoSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint PhotoSkillType_RunningToSuspended_TransitionNumber = 15053;

        /// <summary>
        /// The identifier for the PhotoSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint PhotoSkillType_SuspendedToRunning_TransitionNumber = 15055;

        /// <summary>
        /// The identifier for the PhotoSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint PhotoSkillType_SuspendedToHalted_TransitionNumber = 15057;

        /// <summary>
        /// The identifier for the PhotoSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint PhotoSkillType_SuspendedToReady_TransitionNumber = 15059;

        /// <summary>
        /// The identifier for the PhotoSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint PhotoSkillType_ReadyToHalted_TransitionNumber = 15061;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_Locked Variable.
        /// </summary>
        public const uint CameraDeviceType_Lock_Locked = 15079;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint CameraDeviceType_Lock_LockingClient = 15080;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint CameraDeviceType_Lock_LockingUser = 15081;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint CameraDeviceType_Lock_RemainingLockTime = 15082;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_Lock_InitLock_InputArguments = 15084;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_Lock_InitLock_OutputArguments = 15085;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_Lock_RenewLock_OutputArguments = 15087;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_Lock_ExitLock_OutputArguments = 15089;

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_Lock_BreakLock_OutputArguments = 15091;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_Locked = 15114;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_LockingClient = 15115;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_LockingUser = 15116;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_RemainingLockTime = 15117;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_InitLock_InputArguments = 15119;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 15120;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 15122;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 15124;

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 15126;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_Locked Variable.
        /// </summary>
        public const uint CameraDevice_Lock_Locked = 15149;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_LockingClient Variable.
        /// </summary>
        public const uint CameraDevice_Lock_LockingClient = 15150;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_LockingUser Variable.
        /// </summary>
        public const uint CameraDevice_Lock_LockingUser = 15151;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint CameraDevice_Lock_RemainingLockTime = 15152;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint CameraDevice_Lock_InitLock_InputArguments = 15154;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDevice_Lock_InitLock_OutputArguments = 15155;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDevice_Lock_RenewLock_OutputArguments = 15157;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDevice_Lock_ExitLock_OutputArguments = 15159;

        /// <summary>
        /// The identifier for the CameraDevice_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDevice_Lock_BreakLock_OutputArguments = 15161;

        /// <summary>
        /// The identifier for the CameraDevice_Manufacturer Variable.
        /// </summary>
        public const uint CameraDevice_Manufacturer = 15162;

        /// <summary>
        /// The identifier for the CameraDevice_Model Variable.
        /// </summary>
        public const uint CameraDevice_Model = 15164;

        /// <summary>
        /// The identifier for the CameraDevice_HardwareRevision Variable.
        /// </summary>
        public const uint CameraDevice_HardwareRevision = 15165;

        /// <summary>
        /// The identifier for the CameraDevice_SoftwareRevision Variable.
        /// </summary>
        public const uint CameraDevice_SoftwareRevision = 15166;

        /// <summary>
        /// The identifier for the CameraDevice_DeviceRevision Variable.
        /// </summary>
        public const uint CameraDevice_DeviceRevision = 15167;

        /// <summary>
        /// The identifier for the CameraDevice_DeviceManual Variable.
        /// </summary>
        public const uint CameraDevice_DeviceManual = 15169;

        /// <summary>
        /// The identifier for the CameraDevice_SerialNumber Variable.
        /// </summary>
        public const uint CameraDevice_SerialNumber = 15171;

        /// <summary>
        /// The identifier for the CameraDevice_RevisionCounter Variable.
        /// </summary>
        public const uint CameraDevice_RevisionCounter = 15173;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_Locked = 15184;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_LockingClient = 15185;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_LockingUser = 15186;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_RemainingLockTime = 15187;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_InitLock_InputArguments = 15189;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_InitLock_OutputArguments = 15190;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_RenewLock_OutputArguments = 15192;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_ExitLock_OutputArguments = 15194;

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint CameraDevice_CPIdentifier_Lock_BreakLock_OutputArguments = 15196;

        /// <summary>
        /// The identifier for the CameraDevice_ImagePNG Variable.
        /// </summary>
        public const uint CameraDevice_ImagePNG = 15250;

        /// <summary>
        /// The identifier for the CameraDevice_ParameterSet_CameraInfo Variable.
        /// </summary>
        public const uint CameraDevice_ParameterSet_CameraInfo = 15249;

        /// <summary>
        /// The identifier for the CameraDevice_ParameterSet_CameraPose Variable.
        /// </summary>
        public const uint CameraDevice_ParameterSet_CameraPose = 15209;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_CurrentState Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_CurrentState = 15212;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_CurrentState_Id = 15213;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_CurrentState_Number = 15215;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_LastTransition Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_LastTransition = 15217;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_LastTransition_Id = 15218;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_LastTransition_Number = 15220;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_LastTransition_TransitionTime = 15221;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_Deletable Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_Deletable = 15225;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_AutoDelete Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_AutoDelete = 15226;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_RecycleCount Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_RecycleCount = 15227;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_CreateSessionId = 15229;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_CreateClientName = 15230;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_InvocationCreationTime = 15231;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastTransitionTime = 15232;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodCall = 15233;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodSessionId = 15234;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodInputArguments = 15235;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodOutputArguments = 15236;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodInputValues = 15237;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodOutputValues = 15238;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodCallTime = 15239;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodReturnStatus = 15240;

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint CameraDevice_Skills_PhotoSkill_MaxInstanceCount = 15242;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_InitLock = new ExpandedNodeId(Camera.Methods.CameraDeviceType_Lock_InitLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_RenewLock = new ExpandedNodeId(Camera.Methods.CameraDeviceType_Lock_RenewLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_ExitLock = new ExpandedNodeId(Camera.Methods.CameraDeviceType_Lock_ExitLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_BreakLock = new ExpandedNodeId(Camera.Methods.CameraDeviceType_Lock_BreakLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Camera.Methods.CameraDeviceType_CPIdentifier_Lock_InitLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Camera.Methods.CameraDeviceType_CPIdentifier_Lock_RenewLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Camera.Methods.CameraDeviceType_CPIdentifier_Lock_ExitLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Camera.Methods.CameraDeviceType_CPIdentifier_Lock_BreakLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_InitLock = new ExpandedNodeId(Camera.Methods.CameraDevice_Lock_InitLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_RenewLock = new ExpandedNodeId(Camera.Methods.CameraDevice_Lock_RenewLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_ExitLock = new ExpandedNodeId(Camera.Methods.CameraDevice_Lock_ExitLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_BreakLock = new ExpandedNodeId(Camera.Methods.CameraDevice_Lock_BreakLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Camera.Methods.CameraDevice_CPIdentifier_Lock_InitLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Camera.Methods.CameraDevice_CPIdentifier_Lock_RenewLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Camera.Methods.CameraDevice_CPIdentifier_Lock_ExitLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Camera.Methods.CameraDevice_CPIdentifier_Lock_BreakLock, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_Halt = new ExpandedNodeId(Camera.Methods.CameraDevice_Skills_PhotoSkill_Halt, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_Reset = new ExpandedNodeId(Camera.Methods.CameraDevice_Skills_PhotoSkill_Reset, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_Resume = new ExpandedNodeId(Camera.Methods.CameraDevice_Skills_PhotoSkill_Resume, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_Suspend = new ExpandedNodeId(Camera.Methods.CameraDevice_Skills_PhotoSkill_Suspend, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_Start = new ExpandedNodeId(Camera.Methods.CameraDevice_Skills_PhotoSkill_Start, Camera.Namespaces.Camera);
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
        /// The identifier for the PhotoSkillType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_ParameterSet = new ExpandedNodeId(Camera.Objects.PhotoSkillType_ParameterSet, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Camera.Objects.CameraDeviceType_CPIdentifier_NetworkAddress, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice Object.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice = new ExpandedNodeId(Camera.Objects.CameraDevice, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_ParameterSet = new ExpandedNodeId(Camera.Objects.CameraDevice_ParameterSet, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_NetworkAddress = new ExpandedNodeId(Camera.Objects.CameraDevice_CPIdentifier_NetworkAddress, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills Object.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills = new ExpandedNodeId(Camera.Objects.CameraDevice_Skills, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill = new ExpandedNodeId(Camera.Objects.CameraDevice_Skills_PhotoSkill, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_ParameterSet = new ExpandedNodeId(Camera.Objects.CameraDevice_Skills_PhotoSkill_ParameterSet, Camera.Namespaces.Camera);
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
        /// The identifier for the PhotoSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType = new ExpandedNodeId(Camera.ObjectTypes.PhotoSkillType, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType = new ExpandedNodeId(Camera.ObjectTypes.CameraDeviceType, Camera.Namespaces.Camera);
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
        /// The identifier for the PhotoSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_CurrentState_Id = new ExpandedNodeId(Camera.Variables.PhotoSkillType_CurrentState_Id, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_CurrentState_Number = new ExpandedNodeId(Camera.Variables.PhotoSkillType_CurrentState_Number, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_LastTransition_Id = new ExpandedNodeId(Camera.Variables.PhotoSkillType_LastTransition_Id, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_LastTransition_Number = new ExpandedNodeId(Camera.Variables.PhotoSkillType_LastTransition_Number, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_LastTransition_TransitionTime = new ExpandedNodeId(Camera.Variables.PhotoSkillType_LastTransition_TransitionTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(Camera.Variables.PhotoSkillType_ProgramDiagnostic_CreateSessionId, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(Camera.Variables.PhotoSkillType_ProgramDiagnostic_CreateClientName, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(Camera.Variables.PhotoSkillType_ProgramDiagnostic_InvocationCreationTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(Camera.Variables.PhotoSkillType_ProgramDiagnostic_LastTransitionTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(Camera.Variables.PhotoSkillType_ProgramDiagnostic_LastMethodCall, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(Camera.Variables.PhotoSkillType_ProgramDiagnostic_LastMethodSessionId, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(Camera.Variables.PhotoSkillType_ProgramDiagnostic_LastMethodInputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(Camera.Variables.PhotoSkillType_ProgramDiagnostic_LastMethodOutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(Camera.Variables.PhotoSkillType_ProgramDiagnostic_LastMethodInputValues, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(Camera.Variables.PhotoSkillType_ProgramDiagnostic_LastMethodOutputValues, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(Camera.Variables.PhotoSkillType_ProgramDiagnostic_LastMethodCallTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(Camera.Variables.PhotoSkillType_ProgramDiagnostic_LastMethodReturnStatus, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_Halted_StateNumber = new ExpandedNodeId(Camera.Variables.PhotoSkillType_Halted_StateNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_Ready_StateNumber = new ExpandedNodeId(Camera.Variables.PhotoSkillType_Ready_StateNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_Running_StateNumber = new ExpandedNodeId(Camera.Variables.PhotoSkillType_Running_StateNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_Suspended_StateNumber = new ExpandedNodeId(Camera.Variables.PhotoSkillType_Suspended_StateNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(Camera.Variables.PhotoSkillType_HaltedToReady_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Camera.Variables.PhotoSkillType_ReadyToRunning_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(Camera.Variables.PhotoSkillType_RunningToHalted_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(Camera.Variables.PhotoSkillType_RunningToReady_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Camera.Variables.PhotoSkillType_RunningToSuspended_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Camera.Variables.PhotoSkillType_SuspendedToRunning_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Camera.Variables.PhotoSkillType_SuspendedToHalted_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Camera.Variables.PhotoSkillType_SuspendedToReady_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the PhotoSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PhotoSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Camera.Variables.PhotoSkillType_ReadyToHalted_TransitionNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_Locked = new ExpandedNodeId(Camera.Variables.CameraDeviceType_Lock_Locked, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_LockingClient = new ExpandedNodeId(Camera.Variables.CameraDeviceType_Lock_LockingClient, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_LockingUser = new ExpandedNodeId(Camera.Variables.CameraDeviceType_Lock_LockingUser, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(Camera.Variables.CameraDeviceType_Lock_RemainingLockTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_Lock_InitLock_InputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_Lock_InitLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_Lock_RenewLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_Lock_ExitLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_Lock_BreakLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Camera.Variables.CameraDeviceType_CPIdentifier_Lock_Locked, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Camera.Variables.CameraDeviceType_CPIdentifier_Lock_LockingClient, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Camera.Variables.CameraDeviceType_CPIdentifier_Lock_LockingUser, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Camera.Variables.CameraDeviceType_CPIdentifier_Lock_RemainingLockTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_CPIdentifier_Lock_InitLock_InputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_CPIdentifier_Lock_InitLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_Locked = new ExpandedNodeId(Camera.Variables.CameraDevice_Lock_Locked, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_LockingClient = new ExpandedNodeId(Camera.Variables.CameraDevice_Lock_LockingClient, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_LockingUser = new ExpandedNodeId(Camera.Variables.CameraDevice_Lock_LockingUser, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_RemainingLockTime = new ExpandedNodeId(Camera.Variables.CameraDevice_Lock_RemainingLockTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_InitLock_InputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_Lock_InitLock_InputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_InitLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_Lock_InitLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_Lock_RenewLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_Lock_ExitLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_Lock_BreakLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Manufacturer = new ExpandedNodeId(Camera.Variables.CameraDevice_Manufacturer, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Model = new ExpandedNodeId(Camera.Variables.CameraDevice_Model, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_HardwareRevision = new ExpandedNodeId(Camera.Variables.CameraDevice_HardwareRevision, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_SoftwareRevision = new ExpandedNodeId(Camera.Variables.CameraDevice_SoftwareRevision, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_DeviceRevision = new ExpandedNodeId(Camera.Variables.CameraDevice_DeviceRevision, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_DeviceManual = new ExpandedNodeId(Camera.Variables.CameraDevice_DeviceManual, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_SerialNumber = new ExpandedNodeId(Camera.Variables.CameraDevice_SerialNumber, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_RevisionCounter = new ExpandedNodeId(Camera.Variables.CameraDevice_RevisionCounter, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_Locked = new ExpandedNodeId(Camera.Variables.CameraDevice_CPIdentifier_Lock_Locked, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Camera.Variables.CameraDevice_CPIdentifier_Lock_LockingClient, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Camera.Variables.CameraDevice_CPIdentifier_Lock_LockingUser, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Camera.Variables.CameraDevice_CPIdentifier_Lock_RemainingLockTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_CPIdentifier_Lock_InitLock_InputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_CPIdentifier_Lock_InitLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_CPIdentifier_Lock_RenewLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_CPIdentifier_Lock_ExitLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_CPIdentifier_Lock_BreakLock_OutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_ImagePNG Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_ImagePNG = new ExpandedNodeId(Camera.Variables.CameraDevice_ImagePNG, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_ParameterSet_CameraInfo Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_ParameterSet_CameraInfo = new ExpandedNodeId(Camera.Variables.CameraDevice_ParameterSet_CameraInfo, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_ParameterSet_CameraPose Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_ParameterSet_CameraPose = new ExpandedNodeId(Camera.Variables.CameraDevice_ParameterSet_CameraPose, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_CurrentState = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_CurrentState, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_CurrentState_Id = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_CurrentState_Id, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_CurrentState_Number = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_CurrentState_Number, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_LastTransition = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_LastTransition, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_LastTransition_Id = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_LastTransition_Id, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_LastTransition_Number = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_LastTransition_Number, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_LastTransition_TransitionTime = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_LastTransition_TransitionTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_Deletable = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_Deletable, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_AutoDelete = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_AutoDelete, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_RecycleCount = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_RecycleCount, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_CreateSessionId, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_CreateClientName, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_InvocationCreationTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastTransitionTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodCall, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodSessionId, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodInputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodOutputArguments, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodInputValues, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodOutputValues, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodCallTime, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_ProgramDiagnostic_LastMethodReturnStatus, Camera.Namespaces.Camera);

        /// <summary>
        /// The identifier for the CameraDevice_Skills_PhotoSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraDevice_Skills_PhotoSkill_MaxInstanceCount = new ExpandedNodeId(Camera.Variables.CameraDevice_Skills_PhotoSkill_MaxInstanceCount, Camera.Namespaces.Camera);
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
        /// The BrowseName for the CameraDevice component.
        /// </summary>
        public const string CameraDevice = "CameraDevice";

        /// <summary>
        /// The BrowseName for the CameraDeviceType component.
        /// </summary>
        public const string CameraDeviceType = "CameraDeviceType";

        /// <summary>
        /// The BrowseName for the ImagePNG component.
        /// </summary>
        public const string ImagePNG = "ImagePNG";

        /// <summary>
        /// The BrowseName for the PhotoSkillType component.
        /// </summary>
        public const string PhotoSkillType = "PhotoSkillType";
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
        /// The URI for the Camera namespace (.NET code namespace is 'Camera').
        /// </summary>
        public const string Camera = "https://pnp.org/UA/Camera/";

        /// <summary>
        /// The URI for the CameraXsd namespace (.NET code namespace is 'Camera').
        /// </summary>
        public const string CameraXsd = "https://pnp.org/UA/Camera/Types.xsd";

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

        /// <summary>
        /// The URI for the PnPTypes namespace (.NET code namespace is 'PnPTypes').
        /// </summary>
        public const string PnPTypes = "https://pnp.org/UA/PnPTypes/";

        /// <summary>
        /// The URI for the PnPTypesXsd namespace (.NET code namespace is 'PnPTypes').
        /// </summary>
        public const string PnPTypesXsd = "https://pnp.org/UA/PnPTypes/Types.xsd";
    }
    #endregion
}