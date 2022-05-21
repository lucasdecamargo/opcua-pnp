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

namespace ImageProcessor
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
        /// The identifier for the ImageProcessorDeviceType_Lock_InitLock Method.
        /// </summary>
        public const uint ImageProcessorDeviceType_Lock_InitLock = 15087;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_RenewLock Method.
        /// </summary>
        public const uint ImageProcessorDeviceType_Lock_RenewLock = 15090;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_ExitLock Method.
        /// </summary>
        public const uint ImageProcessorDeviceType_Lock_ExitLock = 15092;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_BreakLock Method.
        /// </summary>
        public const uint ImageProcessorDeviceType_Lock_BreakLock = 15094;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint ImageProcessorDeviceType_CPIdentifier_Lock_InitLock = 15122;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint ImageProcessorDeviceType_CPIdentifier_Lock_RenewLock = 15125;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint ImageProcessorDeviceType_CPIdentifier_Lock_ExitLock = 15127;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint ImageProcessorDeviceType_CPIdentifier_Lock_BreakLock = 15129;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_InitLock Method.
        /// </summary>
        public const uint ImageProcessorDevice_Lock_InitLock = 15157;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_RenewLock Method.
        /// </summary>
        public const uint ImageProcessorDevice_Lock_RenewLock = 15160;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_ExitLock Method.
        /// </summary>
        public const uint ImageProcessorDevice_Lock_ExitLock = 15162;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_BreakLock Method.
        /// </summary>
        public const uint ImageProcessorDevice_Lock_BreakLock = 15164;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint ImageProcessorDevice_CPIdentifier_Lock_InitLock = 15192;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint ImageProcessorDevice_CPIdentifier_Lock_RenewLock = 15195;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint ImageProcessorDevice_CPIdentifier_Lock_ExitLock = 15197;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint ImageProcessorDevice_CPIdentifier_Lock_BreakLock = 15199;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_Halt Method.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_Halt = 15246;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_Reset Method.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_Reset = 15247;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_Resume Method.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_Resume = 15248;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_Suspend Method.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_Suspend = 15249;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_Start Method.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_Start = 15250;
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
        /// The identifier for the MarkerDetectionSkillType_ParameterSet Object.
        /// </summary>
        public const uint MarkerDetectionSkillType_ParameterSet = 15068;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint ImageProcessorDeviceType_CPIdentifier_NetworkAddress = 15131;

        /// <summary>
        /// The identifier for the ImageProcessorDevice Object.
        /// </summary>
        public const uint ImageProcessorDevice = 15143;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint ImageProcessorDevice_CPIdentifier_NetworkAddress = 15201;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills Object.
        /// </summary>
        public const uint ImageProcessorDevice_Skills = 15213;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill Object.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill = 15214;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet Object.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet = 15251;
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
        /// The identifier for the MarkerDetectionSkillType ObjectType.
        /// </summary>
        public const uint MarkerDetectionSkillType = 15001;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType ObjectType.
        /// </summary>
        public const uint ImageProcessorDeviceType = 15073;
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
        /// The identifier for the MarkerDetectionSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_CurrentState_Id = 15003;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_CurrentState_Number = 15005;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_LastTransition_Id = 15008;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_LastTransition_Number = 15010;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_LastTransition_TransitionTime = 15011;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_CreateSessionId = 15023;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_CreateClientName = 15024;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_InvocationCreationTime = 15025;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_LastTransitionTime = 15026;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCall = 15027;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_LastMethodSessionId = 15028;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputArguments = 15029;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15030;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputValues = 15031;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputValues = 15032;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCallTime = 15033;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15034;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_Halted_StateNumber = 15037;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_Ready_StateNumber = 15039;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_Running_StateNumber = 15041;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_Suspended_StateNumber = 15043;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_HaltedToReady_TransitionNumber = 15045;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ReadyToRunning_TransitionNumber = 15047;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_RunningToHalted_TransitionNumber = 15049;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_RunningToReady_TransitionNumber = 15051;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_RunningToSuspended_TransitionNumber = 15053;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_SuspendedToRunning_TransitionNumber = 15055;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_SuspendedToHalted_TransitionNumber = 15057;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_SuspendedToReady_TransitionNumber = 15059;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ReadyToHalted_TransitionNumber = 15061;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ParameterSet_CameraInfo Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ParameterSet_CameraInfo = 15069;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ParameterSet_InputImage Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ParameterSet_InputImage = 15070;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ParameterSet_OutputImage Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ParameterSet_OutputImage = 15071;

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ParameterSet_DetectedMarkersArray Variable.
        /// </summary>
        public const uint MarkerDetectionSkillType_ParameterSet_DetectedMarkersArray = 15072;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_Locked Variable.
        /// </summary>
        public const uint ImageProcessorDeviceType_Lock_Locked = 15083;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint ImageProcessorDeviceType_Lock_LockingClient = 15084;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint ImageProcessorDeviceType_Lock_LockingUser = 15085;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ImageProcessorDeviceType_Lock_RemainingLockTime = 15086;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDeviceType_Lock_InitLock_InputArguments = 15088;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDeviceType_Lock_InitLock_OutputArguments = 15089;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDeviceType_Lock_RenewLock_OutputArguments = 15091;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDeviceType_Lock_ExitLock_OutputArguments = 15093;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDeviceType_Lock_BreakLock_OutputArguments = 15095;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint ImageProcessorDeviceType_CPIdentifier_Lock_Locked = 15118;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint ImageProcessorDeviceType_CPIdentifier_Lock_LockingClient = 15119;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint ImageProcessorDeviceType_CPIdentifier_Lock_LockingUser = 15120;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ImageProcessorDeviceType_CPIdentifier_Lock_RemainingLockTime = 15121;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDeviceType_CPIdentifier_Lock_InitLock_InputArguments = 15123;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 15124;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 15126;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 15128;

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 15130;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_Locked Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Lock_Locked = 15153;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_LockingClient Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Lock_LockingClient = 15154;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_LockingUser Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Lock_LockingUser = 15155;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Lock_RemainingLockTime = 15156;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Lock_InitLock_InputArguments = 15158;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Lock_InitLock_OutputArguments = 15159;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Lock_RenewLock_OutputArguments = 15161;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Lock_ExitLock_OutputArguments = 15163;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Lock_BreakLock_OutputArguments = 15165;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Manufacturer Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Manufacturer = 15166;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Model Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Model = 15168;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_HardwareRevision Variable.
        /// </summary>
        public const uint ImageProcessorDevice_HardwareRevision = 15169;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_SoftwareRevision Variable.
        /// </summary>
        public const uint ImageProcessorDevice_SoftwareRevision = 15170;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_DeviceRevision Variable.
        /// </summary>
        public const uint ImageProcessorDevice_DeviceRevision = 15171;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_DeviceManual Variable.
        /// </summary>
        public const uint ImageProcessorDevice_DeviceManual = 15173;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_SerialNumber Variable.
        /// </summary>
        public const uint ImageProcessorDevice_SerialNumber = 15175;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_RevisionCounter Variable.
        /// </summary>
        public const uint ImageProcessorDevice_RevisionCounter = 15177;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint ImageProcessorDevice_CPIdentifier_Lock_Locked = 15188;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint ImageProcessorDevice_CPIdentifier_Lock_LockingClient = 15189;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint ImageProcessorDevice_CPIdentifier_Lock_LockingUser = 15190;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ImageProcessorDevice_CPIdentifier_Lock_RemainingLockTime = 15191;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDevice_CPIdentifier_Lock_InitLock_InputArguments = 15193;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDevice_CPIdentifier_Lock_InitLock_OutputArguments = 15194;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDevice_CPIdentifier_Lock_RenewLock_OutputArguments = 15196;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDevice_CPIdentifier_Lock_ExitLock_OutputArguments = 15198;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDevice_CPIdentifier_Lock_BreakLock_OutputArguments = 15200;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_CurrentState Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_CurrentState = 15215;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_CurrentState_Id = 15216;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_CurrentState_Number = 15218;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition = 15220;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition_Id = 15221;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition_Number = 15223;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition_TransitionTime = 15224;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_Deletable Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_Deletable = 15228;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_AutoDelete Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_AutoDelete = 15229;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_RecycleCount Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_RecycleCount = 15230;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateSessionId = 15232;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateClientName = 15233;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_InvocationCreationTime = 15234;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastTransitionTime = 15235;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCall = 15236;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodSessionId = 15237;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputArguments = 15238;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputArguments = 15239;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputValues = 15240;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputValues = 15241;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCallTime = 15242;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodReturnStatus = 15243;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_MaxInstanceCount = 15245;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_CameraInfo Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_CameraInfo = 15252;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_InputImage Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_InputImage = 15253;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_OutputImage Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_OutputImage = 15254;

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_DetectedMarkersArray Variable.
        /// </summary>
        public const uint ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_DetectedMarkersArray = 15255;
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
        /// The identifier for the ImageProcessorDeviceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_Lock_InitLock = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDeviceType_Lock_InitLock, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_Lock_RenewLock = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDeviceType_Lock_RenewLock, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_Lock_ExitLock = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDeviceType_Lock_ExitLock, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_Lock_BreakLock = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDeviceType_Lock_BreakLock, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDeviceType_CPIdentifier_Lock_InitLock, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDeviceType_CPIdentifier_Lock_RenewLock, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDeviceType_CPIdentifier_Lock_ExitLock, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDeviceType_CPIdentifier_Lock_BreakLock, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Lock_InitLock = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDevice_Lock_InitLock, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Lock_RenewLock = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDevice_Lock_RenewLock, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Lock_ExitLock = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDevice_Lock_ExitLock, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Lock_BreakLock = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDevice_Lock_BreakLock, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_CPIdentifier_Lock_InitLock = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDevice_CPIdentifier_Lock_InitLock, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDevice_CPIdentifier_Lock_RenewLock, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDevice_CPIdentifier_Lock_ExitLock, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDevice_CPIdentifier_Lock_BreakLock, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_Halt = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDevice_Skills_MarkerDetectionSkill_Halt, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_Reset = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDevice_Skills_MarkerDetectionSkill_Reset, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_Resume = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDevice_Skills_MarkerDetectionSkill_Resume, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_Suspend = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDevice_Skills_MarkerDetectionSkill_Suspend, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_Start = new ExpandedNodeId(ImageProcessor.Methods.ImageProcessorDevice_Skills_MarkerDetectionSkill_Start, ImageProcessor.Namespaces.ImageProcessor);
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
        /// The identifier for the MarkerDetectionSkillType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ParameterSet = new ExpandedNodeId(ImageProcessor.Objects.MarkerDetectionSkillType_ParameterSet, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(ImageProcessor.Objects.ImageProcessorDeviceType_CPIdentifier_NetworkAddress, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice Object.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice = new ExpandedNodeId(ImageProcessor.Objects.ImageProcessorDevice, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_CPIdentifier_NetworkAddress = new ExpandedNodeId(ImageProcessor.Objects.ImageProcessorDevice_CPIdentifier_NetworkAddress, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills Object.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills = new ExpandedNodeId(ImageProcessor.Objects.ImageProcessorDevice_Skills, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill = new ExpandedNodeId(ImageProcessor.Objects.ImageProcessorDevice_Skills_MarkerDetectionSkill, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet = new ExpandedNodeId(ImageProcessor.Objects.ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet, ImageProcessor.Namespaces.ImageProcessor);
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
        /// The identifier for the MarkerDetectionSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType = new ExpandedNodeId(ImageProcessor.ObjectTypes.MarkerDetectionSkillType, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType = new ExpandedNodeId(ImageProcessor.ObjectTypes.ImageProcessorDeviceType, ImageProcessor.Namespaces.ImageProcessor);
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
        /// The identifier for the MarkerDetectionSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_CurrentState_Id = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_CurrentState_Id, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_CurrentState_Number = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_CurrentState_Number, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_LastTransition_Id = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_LastTransition_Id, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_LastTransition_Number = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_LastTransition_Number, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_LastTransition_TransitionTime = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_LastTransition_TransitionTime, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_ProgramDiagnostic_CreateSessionId, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_ProgramDiagnostic_CreateClientName, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_ProgramDiagnostic_InvocationCreationTime, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_ProgramDiagnostic_LastTransitionTime, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCall, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_ProgramDiagnostic_LastMethodSessionId, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_ProgramDiagnostic_LastMethodInputValues, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_ProgramDiagnostic_LastMethodOutputValues, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_ProgramDiagnostic_LastMethodCallTime, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_ProgramDiagnostic_LastMethodReturnStatus, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_Halted_StateNumber = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_Halted_StateNumber, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_Ready_StateNumber = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_Ready_StateNumber, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_Running_StateNumber = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_Running_StateNumber, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_Suspended_StateNumber = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_Suspended_StateNumber, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_HaltedToReady_TransitionNumber, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_ReadyToRunning_TransitionNumber, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_RunningToHalted_TransitionNumber, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_RunningToReady_TransitionNumber, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_RunningToSuspended_TransitionNumber, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_SuspendedToRunning_TransitionNumber, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_SuspendedToHalted_TransitionNumber, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_SuspendedToReady_TransitionNumber, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_ReadyToHalted_TransitionNumber, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ParameterSet_CameraInfo Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ParameterSet_CameraInfo = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_ParameterSet_CameraInfo, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ParameterSet_InputImage Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ParameterSet_InputImage = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_ParameterSet_InputImage, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ParameterSet_OutputImage Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ParameterSet_OutputImage = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_ParameterSet_OutputImage, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the MarkerDetectionSkillType_ParameterSet_DetectedMarkersArray Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerDetectionSkillType_ParameterSet_DetectedMarkersArray = new ExpandedNodeId(ImageProcessor.Variables.MarkerDetectionSkillType_ParameterSet_DetectedMarkersArray, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_Lock_Locked = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDeviceType_Lock_Locked, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_Lock_LockingClient = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDeviceType_Lock_LockingClient, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_Lock_LockingUser = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDeviceType_Lock_LockingUser, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDeviceType_Lock_RemainingLockTime, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDeviceType_Lock_InitLock_InputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDeviceType_Lock_InitLock_OutputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDeviceType_Lock_RenewLock_OutputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDeviceType_Lock_ExitLock_OutputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDeviceType_Lock_BreakLock_OutputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDeviceType_CPIdentifier_Lock_Locked, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDeviceType_CPIdentifier_Lock_LockingClient, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDeviceType_CPIdentifier_Lock_LockingUser, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDeviceType_CPIdentifier_Lock_RemainingLockTime, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDeviceType_CPIdentifier_Lock_InitLock_InputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDeviceType_CPIdentifier_Lock_InitLock_OutputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Lock_Locked = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Lock_Locked, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Lock_LockingClient = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Lock_LockingClient, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Lock_LockingUser = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Lock_LockingUser, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Lock_RemainingLockTime = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Lock_RemainingLockTime, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Lock_InitLock_InputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Lock_InitLock_InputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Lock_InitLock_OutputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Lock_InitLock_OutputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Lock_RenewLock_OutputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Lock_RenewLock_OutputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Lock_ExitLock_OutputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Lock_ExitLock_OutputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Lock_BreakLock_OutputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Lock_BreakLock_OutputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Manufacturer = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Manufacturer, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Model = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Model, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_HardwareRevision = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_HardwareRevision, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_SoftwareRevision = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_SoftwareRevision, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_DeviceRevision = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_DeviceRevision, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_DeviceManual = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_DeviceManual, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_SerialNumber = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_SerialNumber, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_RevisionCounter = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_RevisionCounter, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_CPIdentifier_Lock_Locked = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_CPIdentifier_Lock_Locked, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_CPIdentifier_Lock_LockingClient, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_CPIdentifier_Lock_LockingUser, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_CPIdentifier_Lock_RemainingLockTime, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_CPIdentifier_Lock_InitLock_InputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_CPIdentifier_Lock_InitLock_OutputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_CPIdentifier_Lock_RenewLock_OutputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_CPIdentifier_Lock_ExitLock_OutputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_CPIdentifier_Lock_BreakLock_OutputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_CurrentState = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_CurrentState, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_CurrentState_Id = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_CurrentState_Id, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_CurrentState_Number = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_CurrentState_Number, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition_Id = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition_Id, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition_Number = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition_Number, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition_TransitionTime = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_LastTransition_TransitionTime, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_Deletable = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_Deletable, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_AutoDelete = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_AutoDelete, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_RecycleCount = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_RecycleCount, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateSessionId, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_CreateClientName, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_InvocationCreationTime, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastTransitionTime, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCall, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodSessionId, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputArguments, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodInputValues, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodOutputValues, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodCallTime, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_ProgramDiagnostic_LastMethodReturnStatus, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_MaxInstanceCount = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_MaxInstanceCount, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_CameraInfo Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_CameraInfo = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_CameraInfo, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_InputImage Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_InputImage = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_InputImage, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_OutputImage Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_OutputImage = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_OutputImage, ImageProcessor.Namespaces.ImageProcessor);

        /// <summary>
        /// The identifier for the ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_DetectedMarkersArray Variable.
        /// </summary>
        public static readonly ExpandedNodeId ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_DetectedMarkersArray = new ExpandedNodeId(ImageProcessor.Variables.ImageProcessorDevice_Skills_MarkerDetectionSkill_ParameterSet_DetectedMarkersArray, ImageProcessor.Namespaces.ImageProcessor);
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
        /// The BrowseName for the ImageProcessorDevice component.
        /// </summary>
        public const string ImageProcessorDevice = "ImageProcessorDevice";

        /// <summary>
        /// The BrowseName for the ImageProcessorDeviceType component.
        /// </summary>
        public const string ImageProcessorDeviceType = "ImageProcessorDeviceType";

        /// <summary>
        /// The BrowseName for the MarkerDetectionSkillType component.
        /// </summary>
        public const string MarkerDetectionSkillType = "MarkerDetectionSkillType";
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
        /// The URI for the ImageProcessor namespace (.NET code namespace is 'ImageProcessor').
        /// </summary>
        public const string ImageProcessor = "https://pnp.org/UA/ImageProcessor/";

        /// <summary>
        /// The URI for the ImageProcessorXsd namespace (.NET code namespace is 'ImageProcessor').
        /// </summary>
        public const string ImageProcessorXsd = "https://pnp.org/UA/ImageProcessor/Types.xsd";

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