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

namespace SkillComposer
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
        /// The identifier for the SkillComposerDeviceType_Lock_InitLock Method.
        /// </summary>
        public const uint SkillComposerDeviceType_Lock_InitLock = 15084;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_RenewLock Method.
        /// </summary>
        public const uint SkillComposerDeviceType_Lock_RenewLock = 15087;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_ExitLock Method.
        /// </summary>
        public const uint SkillComposerDeviceType_Lock_ExitLock = 15089;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_BreakLock Method.
        /// </summary>
        public const uint SkillComposerDeviceType_Lock_BreakLock = 15091;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint SkillComposerDeviceType_CPIdentifier_Lock_InitLock = 15119;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint SkillComposerDeviceType_CPIdentifier_Lock_RenewLock = 15122;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint SkillComposerDeviceType_CPIdentifier_Lock_ExitLock = 15124;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint SkillComposerDeviceType_CPIdentifier_Lock_BreakLock = 15126;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_InitLock Method.
        /// </summary>
        public const uint SkillComposerDevice_Lock_InitLock = 15154;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_RenewLock Method.
        /// </summary>
        public const uint SkillComposerDevice_Lock_RenewLock = 15157;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_ExitLock Method.
        /// </summary>
        public const uint SkillComposerDevice_Lock_ExitLock = 15159;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_BreakLock Method.
        /// </summary>
        public const uint SkillComposerDevice_Lock_BreakLock = 15161;

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint SkillComposerDevice_CPIdentifier_Lock_InitLock = 15189;

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint SkillComposerDevice_CPIdentifier_Lock_RenewLock = 15192;

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint SkillComposerDevice_CPIdentifier_Lock_ExitLock = 15194;

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint SkillComposerDevice_CPIdentifier_Lock_BreakLock = 15196;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_Halt Method.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_Halt = 15243;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_Reset Method.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_Reset = 15244;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_Resume Method.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_Resume = 15245;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_Suspend Method.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_Suspend = 15246;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_Start Method.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_Start = 15247;
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
        /// The identifier for the MarkerFindingSkillType_ParameterSet Object.
        /// </summary>
        public const uint MarkerFindingSkillType_ParameterSet = 15068;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint SkillComposerDeviceType_CPIdentifier_NetworkAddress = 15128;

        /// <summary>
        /// The identifier for the SkillComposerDevice Object.
        /// </summary>
        public const uint SkillComposerDevice = 15140;

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint SkillComposerDevice_CPIdentifier_NetworkAddress = 15198;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills Object.
        /// </summary>
        public const uint SkillComposerDevice_Skills = 15210;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill Object.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill = 15211;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ParameterSet Object.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_ParameterSet = 15248;
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
        /// The identifier for the MarkerFindingSkillType ObjectType.
        /// </summary>
        public const uint MarkerFindingSkillType = 15001;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType ObjectType.
        /// </summary>
        public const uint SkillComposerDeviceType = 15070;
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
        /// The identifier for the MarkerFindingSkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_CurrentState_Id = 15003;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_CurrentState_Number = 15005;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_LastTransition_Id = 15008;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_LastTransition_Number = 15010;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_LastTransition_TransitionTime = 15011;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_ProgramDiagnostic_CreateSessionId = 15023;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_ProgramDiagnostic_CreateClientName = 15024;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_ProgramDiagnostic_InvocationCreationTime = 15025;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_ProgramDiagnostic_LastTransitionTime = 15026;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_ProgramDiagnostic_LastMethodCall = 15027;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_ProgramDiagnostic_LastMethodSessionId = 15028;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_ProgramDiagnostic_LastMethodInputArguments = 15029;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_ProgramDiagnostic_LastMethodOutputArguments = 15030;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_ProgramDiagnostic_LastMethodInputValues = 15031;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_ProgramDiagnostic_LastMethodOutputValues = 15032;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_ProgramDiagnostic_LastMethodCallTime = 15033;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_ProgramDiagnostic_LastMethodReturnStatus = 15034;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_Halted_StateNumber = 15037;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_Ready_StateNumber = 15039;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_Running_StateNumber = 15041;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_Suspended_StateNumber = 15043;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_HaltedToReady_TransitionNumber = 15045;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_ReadyToRunning_TransitionNumber = 15047;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_RunningToHalted_TransitionNumber = 15049;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_RunningToReady_TransitionNumber = 15051;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_RunningToSuspended_TransitionNumber = 15053;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_SuspendedToRunning_TransitionNumber = 15055;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_SuspendedToHalted_TransitionNumber = 15057;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_SuspendedToReady_TransitionNumber = 15059;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_ReadyToHalted_TransitionNumber = 15061;

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ParameterSet_FoundMarkersArray Variable.
        /// </summary>
        public const uint MarkerFindingSkillType_ParameterSet_FoundMarkersArray = 15069;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_Locked Variable.
        /// </summary>
        public const uint SkillComposerDeviceType_Lock_Locked = 15080;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint SkillComposerDeviceType_Lock_LockingClient = 15081;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint SkillComposerDeviceType_Lock_LockingUser = 15082;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint SkillComposerDeviceType_Lock_RemainingLockTime = 15083;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint SkillComposerDeviceType_Lock_InitLock_InputArguments = 15085;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint SkillComposerDeviceType_Lock_InitLock_OutputArguments = 15086;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint SkillComposerDeviceType_Lock_RenewLock_OutputArguments = 15088;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint SkillComposerDeviceType_Lock_ExitLock_OutputArguments = 15090;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint SkillComposerDeviceType_Lock_BreakLock_OutputArguments = 15092;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint SkillComposerDeviceType_CPIdentifier_Lock_Locked = 15115;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint SkillComposerDeviceType_CPIdentifier_Lock_LockingClient = 15116;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint SkillComposerDeviceType_CPIdentifier_Lock_LockingUser = 15117;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint SkillComposerDeviceType_CPIdentifier_Lock_RemainingLockTime = 15118;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint SkillComposerDeviceType_CPIdentifier_Lock_InitLock_InputArguments = 15120;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint SkillComposerDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 15121;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint SkillComposerDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 15123;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint SkillComposerDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 15125;

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint SkillComposerDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 15127;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_Locked Variable.
        /// </summary>
        public const uint SkillComposerDevice_Lock_Locked = 15150;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_LockingClient Variable.
        /// </summary>
        public const uint SkillComposerDevice_Lock_LockingClient = 15151;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_LockingUser Variable.
        /// </summary>
        public const uint SkillComposerDevice_Lock_LockingUser = 15152;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint SkillComposerDevice_Lock_RemainingLockTime = 15153;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint SkillComposerDevice_Lock_InitLock_InputArguments = 15155;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint SkillComposerDevice_Lock_InitLock_OutputArguments = 15156;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint SkillComposerDevice_Lock_RenewLock_OutputArguments = 15158;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint SkillComposerDevice_Lock_ExitLock_OutputArguments = 15160;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint SkillComposerDevice_Lock_BreakLock_OutputArguments = 15162;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Manufacturer Variable.
        /// </summary>
        public const uint SkillComposerDevice_Manufacturer = 15163;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Model Variable.
        /// </summary>
        public const uint SkillComposerDevice_Model = 15165;

        /// <summary>
        /// The identifier for the SkillComposerDevice_HardwareRevision Variable.
        /// </summary>
        public const uint SkillComposerDevice_HardwareRevision = 15166;

        /// <summary>
        /// The identifier for the SkillComposerDevice_SoftwareRevision Variable.
        /// </summary>
        public const uint SkillComposerDevice_SoftwareRevision = 15167;

        /// <summary>
        /// The identifier for the SkillComposerDevice_DeviceRevision Variable.
        /// </summary>
        public const uint SkillComposerDevice_DeviceRevision = 15168;

        /// <summary>
        /// The identifier for the SkillComposerDevice_DeviceManual Variable.
        /// </summary>
        public const uint SkillComposerDevice_DeviceManual = 15170;

        /// <summary>
        /// The identifier for the SkillComposerDevice_SerialNumber Variable.
        /// </summary>
        public const uint SkillComposerDevice_SerialNumber = 15172;

        /// <summary>
        /// The identifier for the SkillComposerDevice_RevisionCounter Variable.
        /// </summary>
        public const uint SkillComposerDevice_RevisionCounter = 15174;

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint SkillComposerDevice_CPIdentifier_Lock_Locked = 15185;

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint SkillComposerDevice_CPIdentifier_Lock_LockingClient = 15186;

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint SkillComposerDevice_CPIdentifier_Lock_LockingUser = 15187;

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint SkillComposerDevice_CPIdentifier_Lock_RemainingLockTime = 15188;

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint SkillComposerDevice_CPIdentifier_Lock_InitLock_InputArguments = 15190;

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint SkillComposerDevice_CPIdentifier_Lock_InitLock_OutputArguments = 15191;

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint SkillComposerDevice_CPIdentifier_Lock_RenewLock_OutputArguments = 15193;

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint SkillComposerDevice_CPIdentifier_Lock_ExitLock_OutputArguments = 15195;

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint SkillComposerDevice_CPIdentifier_Lock_BreakLock_OutputArguments = 15197;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_CurrentState Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_CurrentState = 15212;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_CurrentState_Id Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_CurrentState_Id = 15213;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_CurrentState_Number Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_CurrentState_Number = 15215;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition = 15217;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition_Id Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition_Id = 15218;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition_Number Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition_Number = 15220;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition_TransitionTime = 15221;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_Deletable Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_Deletable = 15225;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_AutoDelete Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_AutoDelete = 15226;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_RecycleCount Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_RecycleCount = 15227;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_CreateSessionId = 15229;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_CreateClientName = 15230;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_InvocationCreationTime = 15231;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastTransitionTime = 15232;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodCall = 15233;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodSessionId = 15234;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodInputArguments = 15235;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodOutputArguments = 15236;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodInputValues = 15237;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodOutputValues = 15238;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodCallTime = 15239;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodReturnStatus = 15240;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_MaxInstanceCount Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_MaxInstanceCount = 15242;

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ParameterSet_FoundMarkersArray Variable.
        /// </summary>
        public const uint SkillComposerDevice_Skills_MarkerFindingSkill_ParameterSet_FoundMarkersArray = 15249;
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
        /// The identifier for the SkillComposerDeviceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_Lock_InitLock = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDeviceType_Lock_InitLock, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_Lock_RenewLock = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDeviceType_Lock_RenewLock, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_Lock_ExitLock = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDeviceType_Lock_ExitLock, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_Lock_BreakLock = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDeviceType_Lock_BreakLock, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDeviceType_CPIdentifier_Lock_InitLock, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDeviceType_CPIdentifier_Lock_RenewLock, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDeviceType_CPIdentifier_Lock_ExitLock, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDeviceType_CPIdentifier_Lock_BreakLock, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Lock_InitLock = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDevice_Lock_InitLock, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Lock_RenewLock = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDevice_Lock_RenewLock, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Lock_ExitLock = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDevice_Lock_ExitLock, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Lock_BreakLock = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDevice_Lock_BreakLock, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_CPIdentifier_Lock_InitLock = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDevice_CPIdentifier_Lock_InitLock, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDevice_CPIdentifier_Lock_RenewLock, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDevice_CPIdentifier_Lock_ExitLock, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDevice_CPIdentifier_Lock_BreakLock, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_Halt = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDevice_Skills_MarkerFindingSkill_Halt, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_Reset = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDevice_Skills_MarkerFindingSkill_Reset, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_Resume = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDevice_Skills_MarkerFindingSkill_Resume, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_Suspend = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDevice_Skills_MarkerFindingSkill_Suspend, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_Start = new ExpandedNodeId(SkillComposer.Methods.SkillComposerDevice_Skills_MarkerFindingSkill_Start, SkillComposer.Namespaces.SkillComposer);
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
        /// The identifier for the MarkerFindingSkillType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_ParameterSet = new ExpandedNodeId(SkillComposer.Objects.MarkerFindingSkillType_ParameterSet, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(SkillComposer.Objects.SkillComposerDeviceType_CPIdentifier_NetworkAddress, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice = new ExpandedNodeId(SkillComposer.Objects.SkillComposerDevice, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_CPIdentifier_NetworkAddress = new ExpandedNodeId(SkillComposer.Objects.SkillComposerDevice_CPIdentifier_NetworkAddress, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills = new ExpandedNodeId(SkillComposer.Objects.SkillComposerDevice_Skills, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill = new ExpandedNodeId(SkillComposer.Objects.SkillComposerDevice_Skills_MarkerFindingSkill, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_ParameterSet = new ExpandedNodeId(SkillComposer.Objects.SkillComposerDevice_Skills_MarkerFindingSkill_ParameterSet, SkillComposer.Namespaces.SkillComposer);
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
        /// The identifier for the MarkerFindingSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType = new ExpandedNodeId(SkillComposer.ObjectTypes.MarkerFindingSkillType, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType = new ExpandedNodeId(SkillComposer.ObjectTypes.SkillComposerDeviceType, SkillComposer.Namespaces.SkillComposer);
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
        /// The identifier for the MarkerFindingSkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_CurrentState_Id = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_CurrentState_Id, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_CurrentState_Number = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_CurrentState_Number, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_LastTransition_Id = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_LastTransition_Id, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_LastTransition_Number = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_LastTransition_Number, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_LastTransition_TransitionTime = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_LastTransition_TransitionTime, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_ProgramDiagnostic_CreateSessionId, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_ProgramDiagnostic_CreateClientName, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_ProgramDiagnostic_InvocationCreationTime, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_ProgramDiagnostic_LastTransitionTime, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_ProgramDiagnostic_LastMethodCall, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_ProgramDiagnostic_LastMethodSessionId, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_ProgramDiagnostic_LastMethodInputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_ProgramDiagnostic_LastMethodOutputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_ProgramDiagnostic_LastMethodInputValues, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_ProgramDiagnostic_LastMethodOutputValues, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_ProgramDiagnostic_LastMethodCallTime, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_ProgramDiagnostic_LastMethodReturnStatus, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_Halted_StateNumber = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_Halted_StateNumber, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_Ready_StateNumber = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_Ready_StateNumber, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_Running_StateNumber = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_Running_StateNumber, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_Suspended_StateNumber = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_Suspended_StateNumber, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_HaltedToReady_TransitionNumber, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_ReadyToRunning_TransitionNumber, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_RunningToHalted_TransitionNumber, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_RunningToReady_TransitionNumber, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_RunningToSuspended_TransitionNumber, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_SuspendedToRunning_TransitionNumber, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_SuspendedToHalted_TransitionNumber, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_SuspendedToReady_TransitionNumber, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_ReadyToHalted_TransitionNumber, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the MarkerFindingSkillType_ParameterSet_FoundMarkersArray Variable.
        /// </summary>
        public static readonly ExpandedNodeId MarkerFindingSkillType_ParameterSet_FoundMarkersArray = new ExpandedNodeId(SkillComposer.Variables.MarkerFindingSkillType_ParameterSet_FoundMarkersArray, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_Lock_Locked = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDeviceType_Lock_Locked, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_Lock_LockingClient = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDeviceType_Lock_LockingClient, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_Lock_LockingUser = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDeviceType_Lock_LockingUser, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDeviceType_Lock_RemainingLockTime, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDeviceType_Lock_InitLock_InputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDeviceType_Lock_InitLock_OutputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDeviceType_Lock_RenewLock_OutputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDeviceType_Lock_ExitLock_OutputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDeviceType_Lock_BreakLock_OutputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDeviceType_CPIdentifier_Lock_Locked, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDeviceType_CPIdentifier_Lock_LockingClient, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDeviceType_CPIdentifier_Lock_LockingUser, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDeviceType_CPIdentifier_Lock_RemainingLockTime, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDeviceType_CPIdentifier_Lock_InitLock_InputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDeviceType_CPIdentifier_Lock_InitLock_OutputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Lock_Locked = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Lock_Locked, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Lock_LockingClient = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Lock_LockingClient, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Lock_LockingUser = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Lock_LockingUser, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Lock_RemainingLockTime = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Lock_RemainingLockTime, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Lock_InitLock_InputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Lock_InitLock_InputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Lock_InitLock_OutputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Lock_InitLock_OutputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Lock_RenewLock_OutputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Lock_RenewLock_OutputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Lock_ExitLock_OutputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Lock_ExitLock_OutputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Lock_BreakLock_OutputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Lock_BreakLock_OutputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Manufacturer = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Manufacturer, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Model = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Model, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_HardwareRevision = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_HardwareRevision, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_SoftwareRevision = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_SoftwareRevision, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_DeviceRevision = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_DeviceRevision, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_DeviceManual = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_DeviceManual, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_SerialNumber = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_SerialNumber, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_RevisionCounter = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_RevisionCounter, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_CPIdentifier_Lock_Locked = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_CPIdentifier_Lock_Locked, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_CPIdentifier_Lock_LockingClient, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_CPIdentifier_Lock_LockingUser, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_CPIdentifier_Lock_RemainingLockTime, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_CPIdentifier_Lock_InitLock_InputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_CPIdentifier_Lock_InitLock_OutputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_CPIdentifier_Lock_RenewLock_OutputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_CPIdentifier_Lock_ExitLock_OutputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_CPIdentifier_Lock_BreakLock_OutputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_CurrentState = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_CurrentState, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_CurrentState_Id = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_CurrentState_Id, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_CurrentState_Number = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_CurrentState_Number, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition_Id = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition_Id, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition_Number = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition_Number, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition_TransitionTime = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_LastTransition_TransitionTime, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_Deletable = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_Deletable, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_AutoDelete = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_AutoDelete, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_RecycleCount = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_RecycleCount, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_CreateSessionId, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_CreateClientName, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_InvocationCreationTime, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastTransitionTime, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodCall, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodSessionId, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodInputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodOutputArguments, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodInputValues, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodOutputValues, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodCallTime, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_ProgramDiagnostic_LastMethodReturnStatus, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_MaxInstanceCount = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_MaxInstanceCount, SkillComposer.Namespaces.SkillComposer);

        /// <summary>
        /// The identifier for the SkillComposerDevice_Skills_MarkerFindingSkill_ParameterSet_FoundMarkersArray Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillComposerDevice_Skills_MarkerFindingSkill_ParameterSet_FoundMarkersArray = new ExpandedNodeId(SkillComposer.Variables.SkillComposerDevice_Skills_MarkerFindingSkill_ParameterSet_FoundMarkersArray, SkillComposer.Namespaces.SkillComposer);
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
        /// The BrowseName for the MarkerFindingSkillType component.
        /// </summary>
        public const string MarkerFindingSkillType = "MarkerFindingSkillType";

        /// <summary>
        /// The BrowseName for the SkillComposerDevice component.
        /// </summary>
        public const string SkillComposerDevice = "SkillComposerDevice";

        /// <summary>
        /// The BrowseName for the SkillComposerDeviceType component.
        /// </summary>
        public const string SkillComposerDeviceType = "SkillComposerDeviceType";
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
        /// The URI for the SkillComposer namespace (.NET code namespace is 'SkillComposer').
        /// </summary>
        public const string SkillComposer = "https://pnp.org/UA/SkillComposer/";

        /// <summary>
        /// The URI for the SkillComposerXsd namespace (.NET code namespace is 'SkillComposer').
        /// </summary>
        public const string SkillComposerXsd = "https://pnp.org/UA/SkillComposer/Types.xsd";

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