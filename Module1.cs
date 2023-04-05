using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.InteropServices;

namespace GS4_Calibration_Utility
{
	internal static class Module1
	{
		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern void CloseAllComs();

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern void CloseCom(int Comm);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CommitSettings(int Comm, int BoardNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactGroupMovePercent(int Comm, int BoardNum, ref float ServoPos, float ServoSpeed);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactGroupMoveRaw(int Comm, int BoardNum, ref int ServoPos, float ServoSpeed);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactGroupMoveScaled(int Comm, int BoardNum, ref int ServoPos, float ServoSpeed);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactGroupQuickMovePercent(int Comm, int BoardNum, ref float ServoPos);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactGroupQuickMoveRaw(int Comm, int BoardNum, ref int ServoPos);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactGroupQuickMoveScaled(int Comm, int BoardNum, ref int ServoPos);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactGroupTimedMovePercent(int Comm, int BoardNum, ref float ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactGroupTimedMoveRaw(int Comm, int BoardNum, ref int ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactGroupTimedMoveScaled(int Comm, int BoardNum, ref int ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactMovePercent(int Comm, int BoardNum, int ServoNum, float ServoPos, float ServoSpeed);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactMovePercentCCW(int Comm, int BoardNum, int ServoNum, float ServoPos, float ServoSpeed);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactMovePercentCW(int Comm, int BoardNum, int ServoNum, float ServoPos, float ServoSpeed);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactMoveRaw(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoSpeed);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactMoveRawCCW(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoSpeed);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactMoveRawCW(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoSpeed);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactMoveScaled(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoSpeed);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactMoveScaledCCW(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoSpeed);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactMoveScaledCW(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoSpeed);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactQuickMove(int Comm, int BoardNum, int ServoNum, int ServoPos);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactScaledPercentQuickMove(int Comm, int BoardNum, int ServoNum, float ServoPos);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactScaledQuickMove(int Comm, int BoardNum, int ServoNum, int ServoPos);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactTimedMovePercent(int Comm, int BoardNum, int ServoNum, float ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactTimedMovePercentCCW(int Comm, int BoardNum, int ServoNum, float ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactTimedMovePercentCW(int Comm, int BoardNum, int ServoNum, float ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactTimedMoveRaw(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactTimedMoveRawCCW(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactTimedMoveRawCW(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactTimedMoveScaled(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactTimedMoveScaledCCW(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CompactTimedMoveScaledCW(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short CrossfadePreset(int Comm, int BoardNum, int PresetSlot, float CrossfadeTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short DisplayVersion(int Comm, int BoardNum, ref byte VersionInfo);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GetCurrentPositionPercent(int Comm, int BoardNum, int ServoNum, ref float PosInfo);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GetCurrentPositionRaw(int Comm, int BoardNum, int ServoNum, ref int PosInfo);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GetCurrentPositionScaled(int Comm, int BoardNum, int ServoNum, ref int PosInfo);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GetMaxPosition(int Comm, int BoardNum, int ServoNum, ref int PosInfo);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GetMaxSpeed(int Comm, int BoardNum, int ServoNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GetMinPosition(int Comm, int BoardNum, int ServoNum, ref int PosInfo);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GetPresetControlData(int Comm, int BoardNum, int PresetSlot, ref Module1.SCControlData PresetData);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GetPresetName(int Comm, int BoardNum, int PresetSlot, ref byte PresetName);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GetPresetServoData(int Comm, int BoardNum, int PresetSlot, ref float ServoPos, ref int EncodingMask);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GetPulseWidthMax(int Comm, int BoardNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GetPulseWidthMin(int Comm, int BoardNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GetSequencerLastError(int Comm, int BoardNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GetSequencerStartupMode(int Comm, int BoardNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GetSequencerStatus(int Comm, int BoardNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GetServoDisabledState(int Comm, int BoardNum, int ServoNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GetServoEnableStatus(int Comm, int BoardNum, int ServoNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GetServoInvertStatus(int Comm, int BoardNum, int ServoNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GetSmoothingFactor(int Comm, int BoardNum, int ServoNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GetStartPosition(int Comm, int BoardNum, int ServoNum, ref int PosInfo);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GroupMaskMovePercent(int Comm, int BoardNum, ref float ServoPos, float ServoSpeed);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GroupMaskMoveRaw(int Comm, int BoardNum, ref int ServoPos, float ServoSpeed);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GroupMaskMoveScaled(int Comm, int BoardNum, ref int ServoPos, float ServoSpeed);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GroupMaskQuickMovePercent(int Comm, int BoardNum, ref float ServoPos);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GroupMaskQuickMoveRaw(int Comm, int BoardNum, ref int ServoPos);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GroupMaskQuickMoveScaled(int Comm, int BoardNum, ref int ServoPos);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GroupMaskTimedMovePercent(int Comm, int BoardNum, ref float ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GroupMaskTimedMoveRaw(int Comm, int BoardNum, ref int ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GroupMaskTimedMoveScaled(int Comm, int BoardNum, ref int ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GroupMovePercent(int Comm, int BoardNum, ref float ServoPos, float ServoSpeed);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GroupMoveRaw(int Comm, int BoardNum, ref int ServoPos, float ServoSpeed);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GroupMoveScaled(int Comm, int BoardNum, ref int ServoPos, float ServoSpeed);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GroupQuickMovePercent(int Comm, int BoardNum, ref float ServoPos);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GroupQuickMoveRaw(int Comm, int BoardNum, ref int ServoPos);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GroupQuickMoveScaled(int Comm, int BoardNum, ref int ServoPos);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GroupTimedMovePercent(int Comm, int BoardNum, ref float ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GroupTimedMoveRaw(int Comm, int BoardNum, ref int ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short GroupTimedMoveScaled(int Comm, int BoardNum, ref int ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short InitializePreset(int Comm, int BoardNum, int PresetSlot);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short InitPort(int PortNum, int BaudRate);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short LoadFactorySettings(int Comm, int BoardNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short MovePercent(int Comm, int BoardNum, int ServoNum, float ServoPos, float ServoSpd);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short MovePercentCCW(int Comm, int BoardNum, int ServoNum, float ServoPos, float ServoSpd);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short MovePercentCW(int Comm, int BoardNum, int ServoNum, float ServoPos, float ServoSpd);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short MoveRaw(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoSpd);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short MoveRawCCW(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoSpd);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short MoveRawCW(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoSpd);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short MoveScaled(int Comm, int BoardNum, int ServoNum, int ServoPos, float ScaledServoSpd);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short MoveScaledCCW(int Comm, int BoardNum, int ServoNum, int ServoPos, float ScaledServoSpd);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short MoveScaledCW(int Comm, int BoardNum, int ServoNum, int ServoPos, float ScaledServoSpd);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short QuickLoadPreset(int Comm, int BoardNum, int PresetSlot);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short QuickMovePercent(int Comm, int BoardNum, int ServoNum, float PercentServoPos);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short QuickMoveRaw(int Comm, int BoardNum, int ServoNum, int ServoPos);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short QuickMoveScaled(int Comm, int BoardNum, int ServoNum, int ScaledServoPos);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short ReadAD10(int Comm, int BoardNum, int ADNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short ReadAD8(int Comm, int BoardNum, int ADNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short ReadDIOPinChangeFlag(int Comm, int BoardNum, int DIONum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short ReadDIOPinDirection(int Comm, int BoardNum, int DIONum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short ReadDIOPinStartStateDirection(int Comm, int BoardNum, int DIONum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short ReadDIOPinState(int Comm, int BoardNum, int DIONum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short ReadPresetEEPROM(int Comm, int BoardNum, int Page, ref byte EEPROMData);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short ReadSequencerEEPROM(int Comm, int BoardNum, int Page, ref byte EEPROMData);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short ResetAsStartup(int Comm, int BoardNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short ResetSequencer(int Comm, int BoardNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short ServoDisable(int Comm, int BoardNum, int ServoNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short ServoEnable(int Comm, int BoardNum, int ServoNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short ServoInvert(int Comm, int BoardNum, int ServoNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short ServoUninvert(int Comm, int BoardNum, int ServoNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetAllDIOPinStartStatesDirections(int Comm, int BoardNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetComTimeouts(int Comm, int ReadMultiplier, int ReadConstant, int WriteMultiplier, int WriteConstant);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetDIOPinAsInput(int Comm, int BoardNum, int DIONum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetDIOPinAsOutput(int Comm, int BoardNum, int DIONum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetDIOPinHigh(int Comm, int BoardNum, int DIONum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetDIOPinLow(int Comm, int BoardNum, int DIONum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetDIOPinStartStateDirection(int Comm, int BoardNum, int DIONum, int DIOState);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetLEDMode(int Comm, int BoardNum, int Mode);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetMax(int Comm, int BoardNum, int ServoNum, int ServoPos);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetMaxCurrent(int Comm, int BoardNum, int ServoNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetMaxSpeed(int Comm, int BoardNum, int ServoNum, int ServoSpeed);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetMin(int Comm, int BoardNum, int ServoNum, int ServoPos);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetMinCurrent(int Comm, int BoardNum, int ServoNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetPresetControlData(int Comm, int BoardNum, Module1.SCControlData PresetData);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetPresetName(int Comm, int BoardNum, int PresetSlot, ref byte PresetName);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetPresetServoData(int Comm, int BoardNum, int PresetSlot, ref float ServoPos, int EncodingMask);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetPulseWidthMax(int Comm, int BoardNum, int WidthVal);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetPulseWidthMin(int Comm, int BoardNum, int WidthVal);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetSequencerStartupMode(int Comm, int BoardNum, int SequencerStartupMode);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetServoDisabledStateHigh(int Comm, int BoardNum, int ServoNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetServoDisabledStateLow(int Comm, int BoardNum, int ServoNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetSmoothingFactor(int Comm, int BoardNum, int ServoNum, int SmoothingFactor);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetStart(int Comm, int BoardNum, int ServoNum, int ServoPos);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetStartCurrent(int Comm, int BoardNum, int ServoNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short SetWatchdogTime(int Comm, int BoardNum, int WdTimeTenths);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short StartSequencer(int Comm, int BoardNum, int SequenceArg);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short StopSequencer(int Comm, int BoardNum);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short StoreCurrentAsPreset(int Comm, int BoardNum, int PresetSlot);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short TimedMovePercent(int Comm, int BoardNum, int ServoNum, float ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short TimedMovePercentCCW(int Comm, int BoardNum, int ServoNum, float ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short TimedMovePercentCW(int Comm, int BoardNum, int ServoNum, float ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short TimedMoveRaw(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short TimedMoveRawCCW(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short TimedMoveRawCW(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short TimedMoveScaled(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short TimedMoveScaledCCW(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short TimedMoveScaledCW(int Comm, int BoardNum, int ServoNum, int ServoPos, float ServoTime);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short WriteCharToSequencer(int Comm, int BoardNum, int DataByte);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short WritePresetEEPROM(int Comm, int BoardNum, int Page, ref byte EEPROMData);

		[DllImport("yeisrvo.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		public static extern short WriteSequencerEEPROM(int Comm, int BoardNum, int Page, ref byte EEPROMData);

		public struct SCControlData
		{
			public int ServoEnabledFlags;

			public int DIOSkipFlags;

			public int DIODirections;

			public int DIOValues;
		}
	}
}