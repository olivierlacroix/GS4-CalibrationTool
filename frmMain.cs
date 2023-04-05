// using GS4_Calibration_Utility.My;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace GS4_Calibration_Utility
{
	[DesignerGenerated]
	internal class frmMain : Form
	{
		private static List<WeakReference> __ENCList;

		private IContainer components;

		public ToolTip ToolTip1;

		[AccessedThroughProperty("Scroll_Renamed")]
		private VScrollBarArray _Scroll_Renamed;

		[AccessedThroughProperty("TabControl1")]
		private TabControl _TabControl1;

		[AccessedThroughProperty("TabPanelMove")]
		private TabPage _TabPanelMove;

		[AccessedThroughProperty("ButtonServoPanRight_4_S13")]
		private Button _ButtonServoPanRight_4_S13;

		[AccessedThroughProperty("ButtonServoPanRight_3_S15")]
		private Button _ButtonServoPanRight_3_S15;

		[AccessedThroughProperty("ButtonServoPanRight_2_S5")]
		private Button _ButtonServoPanRight_2_S5;

		[AccessedThroughProperty("ButtonServoPanRight_1_S7")]
		private Button _ButtonServoPanRight_1_S7;

		[AccessedThroughProperty("ButtonServoPanLeft_4_S14")]
		private Button _ButtonServoPanLeft_4_S14;

		[AccessedThroughProperty("ButtonServoPanLeft_3_S12")]
		private Button _ButtonServoPanLeft_3_S12;

		[AccessedThroughProperty("ButtonServoPanLeft_2_S6")]
		private Button _ButtonServoPanLeft_2_S6;

		[AccessedThroughProperty("ButtonServoPanLeft_1_S4")]
		private Button _ButtonServoPanLeft_1_S4;

		[AccessedThroughProperty("ButtonServoBackRight_4_S11")]
		private Button _ButtonServoBackRight_4_S11;

		[AccessedThroughProperty("ButtonServoBackRight_3_S9")]
		private Button _ButtonServoBackRight_3_S9;

		[AccessedThroughProperty("ButtonServoBackRight_2_S3")]
		private Button _ButtonServoBackRight_2_S3;

		[AccessedThroughProperty("ButtonServoBackRight_1_S1")]
		private Button _ButtonServoBackRight_1_S1;

		[AccessedThroughProperty("ButtonServoBackLeft_4_S8")]
		private Button _ButtonServoBackLeft_4_S8;

		[AccessedThroughProperty("ButtonServoBackLeft_3_S10")]
		private Button _ButtonServoBackLeft_3_S10;

		[AccessedThroughProperty("ButtonServoBackLeft_2_S0")]
		private Button _ButtonServoBackLeft_2_S0;

		[AccessedThroughProperty("ButtonServoBackLeft_1_S2")]
		private Button _ButtonServoBackLeft_1_S2;

		[AccessedThroughProperty("ButtonGoToCenterPosition")]
		private Button _ButtonGoToCenterPosition;

		[AccessedThroughProperty("ButtonSetMinPosition")]
		private Button _ButtonSetMinPosition;

		[AccessedThroughProperty("ButtonSetMaxPosition")]
		private Button _ButtonSetMaxPosition;

		[AccessedThroughProperty("ButtonMinPosition")]
		private Button _ButtonMinPosition;

		[AccessedThroughProperty("ButtonMaxPosition")]
		private Button _ButtonMaxPosition;

		[AccessedThroughProperty("VScrollBarCalibration")]
		private VScrollBar _VScrollBarCalibration;

		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;

		[AccessedThroughProperty("_Scroll_10")]
		private VScrollBar __Scroll_10;

		[AccessedThroughProperty("_Scroll_0")]
		private VScrollBar __Scroll_0;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("_Scroll_1")]
		private VScrollBar __Scroll_1;

		[AccessedThroughProperty("_Scroll_15")]
		private VScrollBar __Scroll_15;

		[AccessedThroughProperty("_Scroll_2")]
		private VScrollBar __Scroll_2;

		[AccessedThroughProperty("_Scroll_14")]
		private VScrollBar __Scroll_14;

		[AccessedThroughProperty("_Scroll_3")]
		private VScrollBar __Scroll_3;

		[AccessedThroughProperty("_Scroll_13")]
		private VScrollBar __Scroll_13;

		[AccessedThroughProperty("_Scroll_4")]
		private VScrollBar __Scroll_4;

		[AccessedThroughProperty("_Scroll_12")]
		private VScrollBar __Scroll_12;

		[AccessedThroughProperty("_Scroll_5")]
		private VScrollBar __Scroll_5;

		[AccessedThroughProperty("_Scroll_11")]
		private VScrollBar __Scroll_11;

		[AccessedThroughProperty("_Scroll_6")]
		private VScrollBar __Scroll_6;

		[AccessedThroughProperty("_Scroll_9")]
		private VScrollBar __Scroll_9;

		[AccessedThroughProperty("_Scroll_7")]
		private VScrollBar __Scroll_7;

		[AccessedThroughProperty("_Scroll_8")]
		private VScrollBar __Scroll_8;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("VScrollBarPanLeftPanel")]
		private VScrollBar _VScrollBarPanLeftPanel;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("VScrollBarPanRightPanel")]
		private VScrollBar _VScrollBarPanRightPanel;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("VScrollBarBackLeftPanel")]
		private VScrollBar _VScrollBarBackLeftPanel;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("VScrollBarBackRightPanel")]
		private VScrollBar _VScrollBarBackRightPanel;

		[AccessedThroughProperty("NumericUpDownComPort")]
		private NumericUpDown _NumericUpDownComPort;

		[AccessedThroughProperty("ButtonInitCom")]
		private Button _ButtonInitCom;

		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("ButtonCalAllMax")]
		private Button _ButtonCalAllMax;

		[AccessedThroughProperty("ButtonCalAllMin")]
		private Button _ButtonCalAllMin;

		[AccessedThroughProperty("ButtonDisableAllServos")]
		private Button _ButtonDisableAllServos;

		[AccessedThroughProperty("ButtonEnableAllServos")]
		private Button _ButtonEnableAllServos;

		[AccessedThroughProperty("ButtonCalServoDisableAll")]
		private Button _ButtonCalServoDisableAll;

		[AccessedThroughProperty("ButtonCalServoEnableAll")]
		private Button _ButtonCalServoEnableAll;

		[AccessedThroughProperty("ButtonCommitSettings")]
		private Button _ButtonCommitSettings;

		[AccessedThroughProperty("LabelBackPanelValueLeft")]
		private Label _LabelBackPanelValueLeft;

		[AccessedThroughProperty("LabelPanPanelValueRight")]
		private Label _LabelPanPanelValueRight;

		[AccessedThroughProperty("LabelPanPanelValueLeft")]
		private Label _LabelPanPanelValueLeft;

		[AccessedThroughProperty("LabelBackPanelValueRight")]
		private Label _LabelBackPanelValueRight;

		[AccessedThroughProperty("TabServoValues")]
		private TabPage _TabServoValues;

		[AccessedThroughProperty("TextBoxPR1")]
		private TextBox _TextBoxPR1;

		[AccessedThroughProperty("TextBoxPR2")]
		private TextBox _TextBoxPR2;

		[AccessedThroughProperty("TextBoxPR3")]
		private TextBox _TextBoxPR3;

		[AccessedThroughProperty("TextBoxPR4")]
		private TextBox _TextBoxPR4;

		[AccessedThroughProperty("TextBoxBR4")]
		private TextBox _TextBoxBR4;

		[AccessedThroughProperty("TextBoxBR3")]
		private TextBox _TextBoxBR3;

		[AccessedThroughProperty("TextBoxBR2")]
		private TextBox _TextBoxBR2;

		[AccessedThroughProperty("TextBoxBR1")]
		private TextBox _TextBoxBR1;

		[AccessedThroughProperty("TextBoxPL1")]
		private TextBox _TextBoxPL1;

		[AccessedThroughProperty("TextBoxPL2")]
		private TextBox _TextBoxPL2;

		[AccessedThroughProperty("TextBoxPL3")]
		private TextBox _TextBoxPL3;

		[AccessedThroughProperty("TextBoxPL4")]
		private TextBox _TextBoxPL4;

		[AccessedThroughProperty("TextBoxBL4")]
		private TextBox _TextBoxBL4;

		[AccessedThroughProperty("TextBoxBL3")]
		private TextBox _TextBoxBL3;

		[AccessedThroughProperty("TextBoxBL2")]
		private TextBox _TextBoxBL2;

		[AccessedThroughProperty("TextBoxBL1")]
		private TextBox _TextBoxBL1;

		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[AccessedThroughProperty("LabelBL2Value")]
		private Label _LabelBL2Value;

		[AccessedThroughProperty("LabelBL1Value")]
		private Label _LabelBL1Value;

		[AccessedThroughProperty("ButtonBL1Set")]
		private Button _ButtonBL1Set;

		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		[AccessedThroughProperty("NumericUpDownCalRev2ComPort")]
		private NumericUpDown _NumericUpDownCalRev2ComPort;

		[AccessedThroughProperty("ButtonStart")]
		private Button _ButtonStart;

		[AccessedThroughProperty("ShapeContainer1")]
		private ShapeContainer _ShapeContainer1;

		[AccessedThroughProperty("LineShape1")]
		private LineShape _LineShape1;

		[AccessedThroughProperty("GroupBoxBackLeft")]
		private GroupBox _GroupBoxBackLeft;

		[AccessedThroughProperty("ButtonDecreaseCoarse")]
		private Button _ButtonDecreaseCoarse;

		[AccessedThroughProperty("ButtonDecreaseFine")]
		private Button _ButtonDecreaseFine;

		[AccessedThroughProperty("ButtonIncreaseFine")]
		private Button _ButtonIncreaseFine;

		[AccessedThroughProperty("ButtonIncreaseCoarse")]
		private Button _ButtonIncreaseCoarse;

		[AccessedThroughProperty("ButtonBL4Set")]
		private Button _ButtonBL4Set;

		[AccessedThroughProperty("ButtonBL3Set")]
		private Button _ButtonBL3Set;

		[AccessedThroughProperty("ButtonBL2Set")]
		private Button _ButtonBL2Set;

		[AccessedThroughProperty("GroupBoxPanRight")]
		private GroupBox _GroupBoxPanRight;

		[AccessedThroughProperty("ButtonPR4Set")]
		private Button _ButtonPR4Set;

		[AccessedThroughProperty("ButtonPR3Set")]
		private Button _ButtonPR3Set;

		[AccessedThroughProperty("ButtonPR2Set")]
		private Button _ButtonPR2Set;

		[AccessedThroughProperty("ButtonPR1Set")]
		private Button _ButtonPR1Set;

		[AccessedThroughProperty("GroupBoxPanLeft")]
		private GroupBox _GroupBoxPanLeft;

		[AccessedThroughProperty("ButtonPL4Set")]
		private Button _ButtonPL4Set;

		[AccessedThroughProperty("ButtonPL3Set")]
		private Button _ButtonPL3Set;

		[AccessedThroughProperty("ButtonPL2Set")]
		private Button _ButtonPL2Set;

		[AccessedThroughProperty("ButtonPL1Set")]
		private Button _ButtonPL1Set;

		[AccessedThroughProperty("GroupBoxBackRight")]
		private GroupBox _GroupBoxBackRight;

		[AccessedThroughProperty("ButtonBR4Set")]
		private Button _ButtonBR4Set;

		[AccessedThroughProperty("ButtonBR3Set")]
		private Button _ButtonBR3Set;

		[AccessedThroughProperty("ButtonBR2Set")]
		private Button _ButtonBR2Set;

		[AccessedThroughProperty("ButtonBR1Set")]
		private Button _ButtonBR1Set;

		[AccessedThroughProperty("LineShape3")]
		private LineShape _LineShape3;

		[AccessedThroughProperty("LineShape2")]
		private LineShape _LineShape2;

		[AccessedThroughProperty("Label24")]
		private Label _Label24;

		[AccessedThroughProperty("NumericUpDownInitialPosition")]
		private NumericUpDown _NumericUpDownInitialPosition;

		[AccessedThroughProperty("Label23")]
		private Label _Label23;

		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		[AccessedThroughProperty("NumericUpDownFine")]
		private NumericUpDown _NumericUpDownFine;

		[AccessedThroughProperty("NumericUpDownCoarse")]
		private NumericUpDown _NumericUpDownCoarse;

		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		[AccessedThroughProperty("NumericUpDownMinRange")]
		private NumericUpDown _NumericUpDownMinRange;

		[AccessedThroughProperty("Label25")]
		private Label _Label25;

		[AccessedThroughProperty("NumericUpDownMaxRange")]
		private NumericUpDown _NumericUpDownMaxRange;

		[AccessedThroughProperty("ButtonCommit")]
		private Button _ButtonCommit;

		[AccessedThroughProperty("TabCalRev2")]
		private TabPage _TabCalRev2;

		[AccessedThroughProperty("TabCalibration")]
		private TabPage _TabCalibration;

		public short scboard;

		public short sccom;

		public int scbaud;

		public int CurrentServo;

		public int CurrentServoValue;

		public string CurrentServoButton;

		public int CurrentServoMaxPosition;

		public int Rev2CurrentServo;

		public int Rev2CurrentServoPosition;

		public virtual VScrollBar _Scroll_0
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__Scroll_0;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__Scroll_0 = value;
			}
		}

		public virtual VScrollBar _Scroll_1
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__Scroll_1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__Scroll_1 = value;
			}
		}

		public virtual VScrollBar _Scroll_10
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__Scroll_10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__Scroll_10 = value;
			}
		}

		public virtual VScrollBar _Scroll_11
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__Scroll_11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__Scroll_11 = value;
			}
		}

		public virtual VScrollBar _Scroll_12
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__Scroll_12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__Scroll_12 = value;
			}
		}

		public virtual VScrollBar _Scroll_13
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__Scroll_13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__Scroll_13 = value;
			}
		}

		public virtual VScrollBar _Scroll_14
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__Scroll_14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__Scroll_14 = value;
			}
		}

		public virtual VScrollBar _Scroll_15
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__Scroll_15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__Scroll_15 = value;
			}
		}

		public virtual VScrollBar _Scroll_2
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__Scroll_2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__Scroll_2 = value;
			}
		}

		public virtual VScrollBar _Scroll_3
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__Scroll_3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__Scroll_3 = value;
			}
		}

		public virtual VScrollBar _Scroll_4
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__Scroll_4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__Scroll_4 = value;
			}
		}

		public virtual VScrollBar _Scroll_5
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__Scroll_5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__Scroll_5 = value;
			}
		}

		public virtual VScrollBar _Scroll_6
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__Scroll_6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__Scroll_6 = value;
			}
		}

		public virtual VScrollBar _Scroll_7
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__Scroll_7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__Scroll_7 = value;
			}
		}

		public virtual VScrollBar _Scroll_8
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__Scroll_8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__Scroll_8 = value;
			}
		}

		public virtual VScrollBar _Scroll_9
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__Scroll_9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__Scroll_9 = value;
			}
		}

		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.Button1_Click);
				if (this._Button1 != null)
				{
					this._Button1.Click -= eventHandler;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonBL1Set
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonBL1Set;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonBL1Set_Click);
				if (this._ButtonBL1Set != null)
				{
					this._ButtonBL1Set.Click -= eventHandler;
				}
				this._ButtonBL1Set = value;
				if (this._ButtonBL1Set != null)
				{
					this._ButtonBL1Set.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonBL2Set
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonBL2Set;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonBL2Set_Click);
				if (this._ButtonBL2Set != null)
				{
					this._ButtonBL2Set.Click -= eventHandler;
				}
				this._ButtonBL2Set = value;
				if (this._ButtonBL2Set != null)
				{
					this._ButtonBL2Set.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonBL3Set
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonBL3Set;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonBL3Set_Click);
				if (this._ButtonBL3Set != null)
				{
					this._ButtonBL3Set.Click -= eventHandler;
				}
				this._ButtonBL3Set = value;
				if (this._ButtonBL3Set != null)
				{
					this._ButtonBL3Set.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonBL4Set
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonBL4Set;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonBL4Set_Click);
				if (this._ButtonBL4Set != null)
				{
					this._ButtonBL4Set.Click -= eventHandler;
				}
				this._ButtonBL4Set = value;
				if (this._ButtonBL4Set != null)
				{
					this._ButtonBL4Set.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonBR1Set
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonBR1Set;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonBR1Set_Click);
				if (this._ButtonBR1Set != null)
				{
					this._ButtonBR1Set.Click -= eventHandler;
				}
				this._ButtonBR1Set = value;
				if (this._ButtonBR1Set != null)
				{
					this._ButtonBR1Set.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonBR2Set
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonBR2Set;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonBR2Set_Click);
				if (this._ButtonBR2Set != null)
				{
					this._ButtonBR2Set.Click -= eventHandler;
				}
				this._ButtonBR2Set = value;
				if (this._ButtonBR2Set != null)
				{
					this._ButtonBR2Set.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonBR3Set
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonBR3Set;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonBR3Set_Click);
				if (this._ButtonBR3Set != null)
				{
					this._ButtonBR3Set.Click -= eventHandler;
				}
				this._ButtonBR3Set = value;
				if (this._ButtonBR3Set != null)
				{
					this._ButtonBR3Set.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonBR4Set
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonBR4Set;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonBR4Set_Click);
				if (this._ButtonBR4Set != null)
				{
					this._ButtonBR4Set.Click -= eventHandler;
				}
				this._ButtonBR4Set = value;
				if (this._ButtonBR4Set != null)
				{
					this._ButtonBR4Set.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonCalAllMax
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonCalAllMax;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonCalAllMax_Click);
				if (this._ButtonCalAllMax != null)
				{
					this._ButtonCalAllMax.Click -= eventHandler;
				}
				this._ButtonCalAllMax = value;
				if (this._ButtonCalAllMax != null)
				{
					this._ButtonCalAllMax.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonCalAllMin
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonCalAllMin;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonCalAllMin_Click);
				if (this._ButtonCalAllMin != null)
				{
					this._ButtonCalAllMin.Click -= eventHandler;
				}
				this._ButtonCalAllMin = value;
				if (this._ButtonCalAllMin != null)
				{
					this._ButtonCalAllMin.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonCalServoDisableAll
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonCalServoDisableAll;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonCalServoDisableAll_Click);
				if (this._ButtonCalServoDisableAll != null)
				{
					this._ButtonCalServoDisableAll.Click -= eventHandler;
				}
				this._ButtonCalServoDisableAll = value;
				if (this._ButtonCalServoDisableAll != null)
				{
					this._ButtonCalServoDisableAll.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonCalServoEnableAll
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonCalServoEnableAll;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonCalServoEnableAll_Click);
				if (this._ButtonCalServoEnableAll != null)
				{
					this._ButtonCalServoEnableAll.Click -= eventHandler;
				}
				this._ButtonCalServoEnableAll = value;
				if (this._ButtonCalServoEnableAll != null)
				{
					this._ButtonCalServoEnableAll.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonCommit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonCommit;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonCommit_Click);
				if (this._ButtonCommit != null)
				{
					this._ButtonCommit.Click -= eventHandler;
				}
				this._ButtonCommit = value;
				if (this._ButtonCommit != null)
				{
					this._ButtonCommit.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonCommitSettings
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonCommitSettings;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonCommitSettings_Click);
				if (this._ButtonCommitSettings != null)
				{
					this._ButtonCommitSettings.Click -= eventHandler;
				}
				this._ButtonCommitSettings = value;
				if (this._ButtonCommitSettings != null)
				{
					this._ButtonCommitSettings.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonDecreaseCoarse
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonDecreaseCoarse;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonDecreaseCoarse_Click);
				if (this._ButtonDecreaseCoarse != null)
				{
					this._ButtonDecreaseCoarse.Click -= eventHandler;
				}
				this._ButtonDecreaseCoarse = value;
				if (this._ButtonDecreaseCoarse != null)
				{
					this._ButtonDecreaseCoarse.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonDecreaseFine
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonDecreaseFine;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonDecreaseFine_Click);
				if (this._ButtonDecreaseFine != null)
				{
					this._ButtonDecreaseFine.Click -= eventHandler;
				}
				this._ButtonDecreaseFine = value;
				if (this._ButtonDecreaseFine != null)
				{
					this._ButtonDecreaseFine.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonDisableAllServos
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonDisableAllServos;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonDisableAllServos_Click);
				if (this._ButtonDisableAllServos != null)
				{
					this._ButtonDisableAllServos.Click -= eventHandler;
				}
				this._ButtonDisableAllServos = value;
				if (this._ButtonDisableAllServos != null)
				{
					this._ButtonDisableAllServos.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonEnableAllServos
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonEnableAllServos;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonEnableAllServos_Click);
				if (this._ButtonEnableAllServos != null)
				{
					this._ButtonEnableAllServos.Click -= eventHandler;
				}
				this._ButtonEnableAllServos = value;
				if (this._ButtonEnableAllServos != null)
				{
					this._ButtonEnableAllServos.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonGoToCenterPosition
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonGoToCenterPosition;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonGoToCenterPosition_Click);
				if (this._ButtonGoToCenterPosition != null)
				{
					this._ButtonGoToCenterPosition.Click -= eventHandler;
				}
				this._ButtonGoToCenterPosition = value;
				if (this._ButtonGoToCenterPosition != null)
				{
					this._ButtonGoToCenterPosition.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonIncreaseCoarse
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonIncreaseCoarse;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonIncreaseCoarse_Click);
				if (this._ButtonIncreaseCoarse != null)
				{
					this._ButtonIncreaseCoarse.Click -= eventHandler;
				}
				this._ButtonIncreaseCoarse = value;
				if (this._ButtonIncreaseCoarse != null)
				{
					this._ButtonIncreaseCoarse.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonIncreaseFine
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonIncreaseFine;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonIncreaseFine_Click);
				if (this._ButtonIncreaseFine != null)
				{
					this._ButtonIncreaseFine.Click -= eventHandler;
				}
				this._ButtonIncreaseFine = value;
				if (this._ButtonIncreaseFine != null)
				{
					this._ButtonIncreaseFine.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonInitCom
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonInitCom;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonInitCom_Click);
				if (this._ButtonInitCom != null)
				{
					this._ButtonInitCom.Click -= eventHandler;
				}
				this._ButtonInitCom = value;
				if (this._ButtonInitCom != null)
				{
					this._ButtonInitCom.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonMaxPosition
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonMaxPosition;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonMaxPosition_Click);
				if (this._ButtonMaxPosition != null)
				{
					this._ButtonMaxPosition.Click -= eventHandler;
				}
				this._ButtonMaxPosition = value;
				if (this._ButtonMaxPosition != null)
				{
					this._ButtonMaxPosition.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonMinPosition
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonMinPosition;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonMinPosition_Click);
				if (this._ButtonMinPosition != null)
				{
					this._ButtonMinPosition.Click -= eventHandler;
				}
				this._ButtonMinPosition = value;
				if (this._ButtonMinPosition != null)
				{
					this._ButtonMinPosition.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonPL1Set
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonPL1Set;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonPL1Set_Click);
				if (this._ButtonPL1Set != null)
				{
					this._ButtonPL1Set.Click -= eventHandler;
				}
				this._ButtonPL1Set = value;
				if (this._ButtonPL1Set != null)
				{
					this._ButtonPL1Set.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonPL2Set
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonPL2Set;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonPL2Set_Click);
				if (this._ButtonPL2Set != null)
				{
					this._ButtonPL2Set.Click -= eventHandler;
				}
				this._ButtonPL2Set = value;
				if (this._ButtonPL2Set != null)
				{
					this._ButtonPL2Set.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonPL3Set
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonPL3Set;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonPL3Set_Click);
				if (this._ButtonPL3Set != null)
				{
					this._ButtonPL3Set.Click -= eventHandler;
				}
				this._ButtonPL3Set = value;
				if (this._ButtonPL3Set != null)
				{
					this._ButtonPL3Set.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonPL4Set
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonPL4Set;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonPL4Set_Click);
				if (this._ButtonPL4Set != null)
				{
					this._ButtonPL4Set.Click -= eventHandler;
				}
				this._ButtonPL4Set = value;
				if (this._ButtonPL4Set != null)
				{
					this._ButtonPL4Set.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonPR1Set
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonPR1Set;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonPR1Set_Click);
				if (this._ButtonPR1Set != null)
				{
					this._ButtonPR1Set.Click -= eventHandler;
				}
				this._ButtonPR1Set = value;
				if (this._ButtonPR1Set != null)
				{
					this._ButtonPR1Set.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonPR2Set
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonPR2Set;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonPR2Set_Click);
				if (this._ButtonPR2Set != null)
				{
					this._ButtonPR2Set.Click -= eventHandler;
				}
				this._ButtonPR2Set = value;
				if (this._ButtonPR2Set != null)
				{
					this._ButtonPR2Set.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonPR3Set
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonPR3Set;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonPR3Set_Click);
				if (this._ButtonPR3Set != null)
				{
					this._ButtonPR3Set.Click -= eventHandler;
				}
				this._ButtonPR3Set = value;
				if (this._ButtonPR3Set != null)
				{
					this._ButtonPR3Set.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonPR4Set
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonPR4Set;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonPR4Set_Click);
				if (this._ButtonPR4Set != null)
				{
					this._ButtonPR4Set.Click -= eventHandler;
				}
				this._ButtonPR4Set = value;
				if (this._ButtonPR4Set != null)
				{
					this._ButtonPR4Set.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonServoBackLeft_1_S2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonServoBackLeft_1_S2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonServoBackLeft_1_S2_Click);
				if (this._ButtonServoBackLeft_1_S2 != null)
				{
					this._ButtonServoBackLeft_1_S2.Click -= eventHandler;
				}
				this._ButtonServoBackLeft_1_S2 = value;
				if (this._ButtonServoBackLeft_1_S2 != null)
				{
					this._ButtonServoBackLeft_1_S2.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonServoBackLeft_2_S0
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonServoBackLeft_2_S0;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonServoBackLeft_2_S0_Click);
				if (this._ButtonServoBackLeft_2_S0 != null)
				{
					this._ButtonServoBackLeft_2_S0.Click -= eventHandler;
				}
				this._ButtonServoBackLeft_2_S0 = value;
				if (this._ButtonServoBackLeft_2_S0 != null)
				{
					this._ButtonServoBackLeft_2_S0.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonServoBackLeft_3_S10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonServoBackLeft_3_S10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonServoBackLeft_3_S10_Click);
				if (this._ButtonServoBackLeft_3_S10 != null)
				{
					this._ButtonServoBackLeft_3_S10.Click -= eventHandler;
				}
				this._ButtonServoBackLeft_3_S10 = value;
				if (this._ButtonServoBackLeft_3_S10 != null)
				{
					this._ButtonServoBackLeft_3_S10.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonServoBackLeft_4_S8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonServoBackLeft_4_S8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonServoBackLeft_4_S8_Click);
				if (this._ButtonServoBackLeft_4_S8 != null)
				{
					this._ButtonServoBackLeft_4_S8.Click -= eventHandler;
				}
				this._ButtonServoBackLeft_4_S8 = value;
				if (this._ButtonServoBackLeft_4_S8 != null)
				{
					this._ButtonServoBackLeft_4_S8.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonServoBackRight_1_S1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonServoBackRight_1_S1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonServoBackRight_1_S1_Click);
				if (this._ButtonServoBackRight_1_S1 != null)
				{
					this._ButtonServoBackRight_1_S1.Click -= eventHandler;
				}
				this._ButtonServoBackRight_1_S1 = value;
				if (this._ButtonServoBackRight_1_S1 != null)
				{
					this._ButtonServoBackRight_1_S1.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonServoBackRight_2_S3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonServoBackRight_2_S3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonServoBackRight_2_S3_Click);
				if (this._ButtonServoBackRight_2_S3 != null)
				{
					this._ButtonServoBackRight_2_S3.Click -= eventHandler;
				}
				this._ButtonServoBackRight_2_S3 = value;
				if (this._ButtonServoBackRight_2_S3 != null)
				{
					this._ButtonServoBackRight_2_S3.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonServoBackRight_3_S9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonServoBackRight_3_S9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonServoBackRight_3_S9_Click);
				if (this._ButtonServoBackRight_3_S9 != null)
				{
					this._ButtonServoBackRight_3_S9.Click -= eventHandler;
				}
				this._ButtonServoBackRight_3_S9 = value;
				if (this._ButtonServoBackRight_3_S9 != null)
				{
					this._ButtonServoBackRight_3_S9.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonServoBackRight_4_S11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonServoBackRight_4_S11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonServoBackRight_4_S11_Click);
				if (this._ButtonServoBackRight_4_S11 != null)
				{
					this._ButtonServoBackRight_4_S11.Click -= eventHandler;
				}
				this._ButtonServoBackRight_4_S11 = value;
				if (this._ButtonServoBackRight_4_S11 != null)
				{
					this._ButtonServoBackRight_4_S11.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonServoPanLeft_1_S4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonServoPanLeft_1_S4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonServoPanLeft_1_S4_Click);
				if (this._ButtonServoPanLeft_1_S4 != null)
				{
					this._ButtonServoPanLeft_1_S4.Click -= eventHandler;
				}
				this._ButtonServoPanLeft_1_S4 = value;
				if (this._ButtonServoPanLeft_1_S4 != null)
				{
					this._ButtonServoPanLeft_1_S4.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonServoPanLeft_2_S6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonServoPanLeft_2_S6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonServoPanLeft_2_S6_Click);
				if (this._ButtonServoPanLeft_2_S6 != null)
				{
					this._ButtonServoPanLeft_2_S6.Click -= eventHandler;
				}
				this._ButtonServoPanLeft_2_S6 = value;
				if (this._ButtonServoPanLeft_2_S6 != null)
				{
					this._ButtonServoPanLeft_2_S6.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonServoPanLeft_3_S12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonServoPanLeft_3_S12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonServoPanLeft_3_S12_Click);
				if (this._ButtonServoPanLeft_3_S12 != null)
				{
					this._ButtonServoPanLeft_3_S12.Click -= eventHandler;
				}
				this._ButtonServoPanLeft_3_S12 = value;
				if (this._ButtonServoPanLeft_3_S12 != null)
				{
					this._ButtonServoPanLeft_3_S12.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonServoPanLeft_4_S14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonServoPanLeft_4_S14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonServoPanLeft_4_S14_Click);
				if (this._ButtonServoPanLeft_4_S14 != null)
				{
					this._ButtonServoPanLeft_4_S14.Click -= eventHandler;
				}
				this._ButtonServoPanLeft_4_S14 = value;
				if (this._ButtonServoPanLeft_4_S14 != null)
				{
					this._ButtonServoPanLeft_4_S14.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonServoPanRight_1_S7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonServoPanRight_1_S7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonServoPanRight_1_S7_Click);
				if (this._ButtonServoPanRight_1_S7 != null)
				{
					this._ButtonServoPanRight_1_S7.Click -= eventHandler;
				}
				this._ButtonServoPanRight_1_S7 = value;
				if (this._ButtonServoPanRight_1_S7 != null)
				{
					this._ButtonServoPanRight_1_S7.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonServoPanRight_2_S5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonServoPanRight_2_S5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonServoPanRight_2_S5_Click);
				if (this._ButtonServoPanRight_2_S5 != null)
				{
					this._ButtonServoPanRight_2_S5.Click -= eventHandler;
				}
				this._ButtonServoPanRight_2_S5 = value;
				if (this._ButtonServoPanRight_2_S5 != null)
				{
					this._ButtonServoPanRight_2_S5.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonServoPanRight_3_S15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonServoPanRight_3_S15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonServoPanRight_3_S15_Click);
				if (this._ButtonServoPanRight_3_S15 != null)
				{
					this._ButtonServoPanRight_3_S15.Click -= eventHandler;
				}
				this._ButtonServoPanRight_3_S15 = value;
				if (this._ButtonServoPanRight_3_S15 != null)
				{
					this._ButtonServoPanRight_3_S15.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonServoPanRight_4_S13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonServoPanRight_4_S13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonServoPanRight_4_S13_Click);
				if (this._ButtonServoPanRight_4_S13 != null)
				{
					this._ButtonServoPanRight_4_S13.Click -= eventHandler;
				}
				this._ButtonServoPanRight_4_S13 = value;
				if (this._ButtonServoPanRight_4_S13 != null)
				{
					this._ButtonServoPanRight_4_S13.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonSetMaxPosition
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonSetMaxPosition;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonSetMaxPosition_Click);
				if (this._ButtonSetMaxPosition != null)
				{
					this._ButtonSetMaxPosition.Click -= eventHandler;
				}
				this._ButtonSetMaxPosition = value;
				if (this._ButtonSetMaxPosition != null)
				{
					this._ButtonSetMaxPosition.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonSetMinPosition
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonSetMinPosition;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonSetMinPosition_Click);
				if (this._ButtonSetMinPosition != null)
				{
					this._ButtonSetMinPosition.Click -= eventHandler;
				}
				this._ButtonSetMinPosition = value;
				if (this._ButtonSetMinPosition != null)
				{
					this._ButtonSetMinPosition.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonStart
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonStart;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.ButtonStart_Click);
				if (this._ButtonStart != null)
				{
					this._ButtonStart.Click -= eventHandler;
				}
				this._ButtonStart = value;
				if (this._ButtonStart != null)
				{
					this._ButtonStart.Click += eventHandler;
				}
			}
		}

		internal virtual GroupBox GroupBoxBackLeft
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBoxBackLeft;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBoxBackLeft = value;
			}
		}

		internal virtual GroupBox GroupBoxBackRight
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBoxBackRight;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBoxBackRight = value;
			}
		}

		internal virtual GroupBox GroupBoxPanLeft
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBoxPanLeft;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBoxPanLeft = value;
			}
		}

		internal virtual GroupBox GroupBoxPanRight
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBoxPanRight;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBoxPanRight = value;
			}
		}

		public virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		internal virtual Label Label10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label10 = value;
			}
		}

		internal virtual Label Label11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label11 = value;
			}
		}

		internal virtual Label Label12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label12 = value;
			}
		}

		internal virtual Label Label13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label13 = value;
			}
		}

		internal virtual Label Label14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label14 = value;
			}
		}

		internal virtual Label Label15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label15 = value;
			}
		}

		internal virtual Label Label16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label16 = value;
			}
		}

		internal virtual Label Label17
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label17;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label17 = value;
			}
		}

		internal virtual Label Label18
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label18;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label18 = value;
			}
		}

		internal virtual Label Label19
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label19;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label19 = value;
			}
		}

		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		internal virtual Label Label20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label20 = value;
			}
		}

		internal virtual Label Label21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label21 = value;
			}
		}

		internal virtual Label Label22
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label22;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label22 = value;
			}
		}

		internal virtual Label Label23
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label23;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label23 = value;
			}
		}

		internal virtual Label Label24
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label24;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label24 = value;
			}
		}

		internal virtual Label Label25
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label25;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label25 = value;
			}
		}

		internal virtual Label Label26
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label26;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label26 = value;
			}
		}

		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		internal virtual Label Label9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label9 = value;
			}
		}

		internal virtual Label LabelBackPanelValueLeft
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelBackPanelValueLeft;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelBackPanelValueLeft = value;
			}
		}

		internal virtual Label LabelBackPanelValueRight
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelBackPanelValueRight;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelBackPanelValueRight = value;
			}
		}

		internal virtual Label LabelBL1Value
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelBL1Value;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.LabelBL1Value_Click);
				if (this._LabelBL1Value != null)
				{
					this._LabelBL1Value.Click -= eventHandler;
				}
				this._LabelBL1Value = value;
				if (this._LabelBL1Value != null)
				{
					this._LabelBL1Value.Click += eventHandler;
				}
			}
		}

		internal virtual Label LabelBL2Value
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelBL2Value;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelBL2Value = value;
			}
		}

		internal virtual Label LabelPanPanelValueLeft
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelPanPanelValueLeft;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelPanPanelValueLeft = value;
			}
		}

		internal virtual Label LabelPanPanelValueRight
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelPanPanelValueRight;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelPanPanelValueRight = value;
			}
		}

		internal virtual LineShape LineShape1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LineShape1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LineShape1 = value;
			}
		}

		internal virtual LineShape LineShape2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LineShape2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LineShape2 = value;
			}
		}

		internal virtual LineShape LineShape3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LineShape3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LineShape3 = value;
			}
		}

		internal virtual NumericUpDown NumericUpDownCalRev2ComPort
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDownCalRev2ComPort;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDownCalRev2ComPort = value;
			}
		}

		internal virtual NumericUpDown NumericUpDownCoarse
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDownCoarse;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDownCoarse = value;
			}
		}

		internal virtual NumericUpDown NumericUpDownComPort
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDownComPort;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.NumericUpDownComPort_ValueChanged);
				if (this._NumericUpDownComPort != null)
				{
					this._NumericUpDownComPort.ValueChanged -= eventHandler;
				}
				this._NumericUpDownComPort = value;
				if (this._NumericUpDownComPort != null)
				{
					this._NumericUpDownComPort.ValueChanged += eventHandler;
				}
			}
		}

		internal virtual NumericUpDown NumericUpDownFine
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDownFine;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDownFine = value;
			}
		}

		internal virtual NumericUpDown NumericUpDownInitialPosition
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDownInitialPosition;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDownInitialPosition = value;
			}
		}

		internal virtual NumericUpDown NumericUpDownMaxRange
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDownMaxRange;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDownMaxRange = value;
			}
		}

		internal virtual NumericUpDown NumericUpDownMinRange
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDownMinRange;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDownMinRange = value;
			}
		}

		public virtual VScrollBarArray Scroll_Renamed
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Scroll_Renamed;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				ScrollEventHandler scrollEventHandler = new ScrollEventHandler(_frmMain.Scroll_Renamed_Scroll);
				if (this._Scroll_Renamed != null)
				{
					this._Scroll_Renamed.Scroll -= scrollEventHandler;
				}
				this._Scroll_Renamed = value;
				if (this._Scroll_Renamed != null)
				{
					this._Scroll_Renamed.Scroll += scrollEventHandler;
				}
			}
		}

		internal virtual ShapeContainer ShapeContainer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ShapeContainer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ShapeContainer1 = value;
			}
		}

		internal virtual TabPage TabCalibration
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabCalibration;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabCalibration = value;
			}
		}

		internal virtual TabPage TabCalRev2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabCalRev2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabCalRev2 = value;
			}
		}

		internal virtual TabControl TabControl1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabControl1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabControl1 = value;
			}
		}

		internal virtual TabPage TabPage1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage1 = value;
			}
		}

		internal virtual TabPage TabPanelMove
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPanelMove;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPanelMove = value;
			}
		}

		internal virtual TabPage TabServoValues
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabServoValues;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabServoValues = value;
			}
		}

		internal virtual TextBox TextBoxBL1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBoxBL1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxBL1 = value;
			}
		}

		internal virtual TextBox TextBoxBL2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBoxBL2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxBL2 = value;
			}
		}

		internal virtual TextBox TextBoxBL3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBoxBL3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxBL3 = value;
			}
		}

		internal virtual TextBox TextBoxBL4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBoxBL4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxBL4 = value;
			}
		}

		internal virtual TextBox TextBoxBR1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBoxBR1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxBR1 = value;
			}
		}

		internal virtual TextBox TextBoxBR2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBoxBR2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxBR2 = value;
			}
		}

		internal virtual TextBox TextBoxBR3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBoxBR3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxBR3 = value;
			}
		}

		internal virtual TextBox TextBoxBR4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBoxBR4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxBR4 = value;
			}
		}

		internal virtual TextBox TextBoxPL1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBoxPL1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxPL1 = value;
			}
		}

		internal virtual TextBox TextBoxPL2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBoxPL2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxPL2 = value;
			}
		}

		internal virtual TextBox TextBoxPL3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBoxPL3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxPL3 = value;
			}
		}

		internal virtual TextBox TextBoxPL4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBoxPL4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxPL4 = value;
			}
		}

		internal virtual TextBox TextBoxPR1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBoxPR1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxPR1 = value;
			}
		}

		internal virtual TextBox TextBoxPR2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBoxPR2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxPR2 = value;
			}
		}

		internal virtual TextBox TextBoxPR3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBoxPR3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxPR3 = value;
			}
		}

		internal virtual TextBox TextBoxPR4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBoxPR4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBoxPR4 = value;
			}
		}

		internal virtual VScrollBar VScrollBarBackLeftPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._VScrollBarBackLeftPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				ScrollEventHandler scrollEventHandler = new ScrollEventHandler(_frmMain.VScrollBarBackLeftPanel_Scroll);
				if (this._VScrollBarBackLeftPanel != null)
				{
					this._VScrollBarBackLeftPanel.Scroll -= scrollEventHandler;
				}
				this._VScrollBarBackLeftPanel = value;
				if (this._VScrollBarBackLeftPanel != null)
				{
					this._VScrollBarBackLeftPanel.Scroll += scrollEventHandler;
				}
			}
		}

		internal virtual VScrollBar VScrollBarBackRightPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._VScrollBarBackRightPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				ScrollEventHandler scrollEventHandler = new ScrollEventHandler(_frmMain.VScrollBarBackRightPanel_Scroll);
				if (this._VScrollBarBackRightPanel != null)
				{
					this._VScrollBarBackRightPanel.Scroll -= scrollEventHandler;
				}
				this._VScrollBarBackRightPanel = value;
				if (this._VScrollBarBackRightPanel != null)
				{
					this._VScrollBarBackRightPanel.Scroll += scrollEventHandler;
				}
			}
		}

		public virtual VScrollBar VScrollBarCalibration
		{
			[DebuggerNonUserCode]
			get
			{
				return this._VScrollBarCalibration;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				ScrollEventHandler scrollEventHandler = new ScrollEventHandler(_frmMain.VScrollBarCalibration_Scroll);
				if (this._VScrollBarCalibration != null)
				{
					this._VScrollBarCalibration.Scroll -= scrollEventHandler;
				}
				this._VScrollBarCalibration = value;
				if (this._VScrollBarCalibration != null)
				{
					this._VScrollBarCalibration.Scroll += scrollEventHandler;
				}
			}
		}

		internal virtual VScrollBar VScrollBarPanLeftPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._VScrollBarPanLeftPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				ScrollEventHandler scrollEventHandler = new ScrollEventHandler(_frmMain.VScrollBarPanLeftPanel_Scroll);
				if (this._VScrollBarPanLeftPanel != null)
				{
					this._VScrollBarPanLeftPanel.Scroll -= scrollEventHandler;
				}
				this._VScrollBarPanLeftPanel = value;
				if (this._VScrollBarPanLeftPanel != null)
				{
					this._VScrollBarPanLeftPanel.Scroll += scrollEventHandler;
				}
			}
		}

		internal virtual VScrollBar VScrollBarPanRightPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._VScrollBarPanRightPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				ScrollEventHandler scrollEventHandler = new ScrollEventHandler(_frmMain.VScrollBarPanRightPanel_Scroll);
				if (this._VScrollBarPanRightPanel != null)
				{
					this._VScrollBarPanRightPanel.Scroll -= scrollEventHandler;
				}
				this._VScrollBarPanRightPanel = value;
				if (this._VScrollBarPanRightPanel != null)
				{
					this._VScrollBarPanRightPanel.Scroll += scrollEventHandler;
				}
			}
		}

		[DebuggerNonUserCode]
		static frmMain()
		{
			frmMain.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		public frmMain()
		{
			frmMain _frmMain = this;
			base.Load += new EventHandler(_frmMain.frmMain_Load);
			frmMain _frmMain1 = this;
			base.FormClosed += new FormClosedEventHandler(_frmMain1.frmMain_FormClosed);
			frmMain.__ENCAddToList(this);
			this.Rev2CurrentServo = 2;
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (frmMain.__ENCList)
			{
				if (frmMain.__ENCList.Count == frmMain.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(frmMain.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (frmMain.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								frmMain.__ENCList[item] = frmMain.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					frmMain.__ENCList.RemoveRange(item, checked(frmMain.__ENCList.Count - item));
					frmMain.__ENCList.Capacity = frmMain.__ENCList.Count;
				}
				frmMain.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
		}

		private void ButtonBL1Set_Click(object sender, EventArgs e)
		{
			Module1.SetMax(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Add(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMaxRange.Value)));
			Module1.SetMin(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Subtract(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMinRange.Value)));
			Module1.SetStart(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
			this.ButtonBL1Set.Enabled = false;
			this.ButtonBL1Set.BackColor = Color.GreenYellow;
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			this.Rev2CurrentServo = 0;
			this.Rev2CurrentServoPosition = Convert.ToInt32(this.NumericUpDownInitialPosition.Value);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(this.NumericUpDownInitialPosition.Value));
			this.ButtonBL2Set.Enabled = true;
			this.ButtonBL2Set.BackColor = Color.Yellow;
		}

		private void ButtonBL2Set_Click(object sender, EventArgs e)
		{
			Module1.SetMax(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Add(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMaxRange.Value)));
			Module1.SetMin(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Subtract(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMinRange.Value)));
			Module1.SetStart(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
			this.ButtonBL2Set.Enabled = false;
			this.ButtonBL2Set.BackColor = Color.GreenYellow;
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			this.Rev2CurrentServo = 10;
			this.Rev2CurrentServoPosition = Convert.ToInt32(this.NumericUpDownInitialPosition.Value);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(this.NumericUpDownInitialPosition.Value));
			this.ButtonBL3Set.Enabled = true;
			this.ButtonBL3Set.BackColor = Color.Yellow;
		}

		private void ButtonBL3Set_Click(object sender, EventArgs e)
		{
			Module1.SetMax(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Add(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMaxRange.Value)));
			Module1.SetMin(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Subtract(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMinRange.Value)));
			Module1.SetStart(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
			this.ButtonBL3Set.Enabled = false;
			this.ButtonBL3Set.BackColor = Color.GreenYellow;
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			this.Rev2CurrentServo = 8;
			this.Rev2CurrentServoPosition = Convert.ToInt32(this.NumericUpDownInitialPosition.Value);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(this.NumericUpDownInitialPosition.Value));
			this.ButtonBL4Set.Enabled = true;
			this.ButtonBL4Set.BackColor = Color.Yellow;
		}

		private void ButtonBL4Set_Click(object sender, EventArgs e)
		{
			Module1.SetMax(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Add(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMaxRange.Value)));
			Module1.SetMin(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Subtract(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMinRange.Value)));
			Module1.SetStart(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
			this.ButtonBL4Set.Enabled = false;
			this.ButtonBL4Set.BackColor = Color.GreenYellow;
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			this.Rev2CurrentServo = 1;
			this.Rev2CurrentServoPosition = Convert.ToInt32(this.NumericUpDownInitialPosition.Value);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(this.NumericUpDownInitialPosition.Value));
			this.ButtonBR1Set.Enabled = true;
			this.ButtonBR1Set.BackColor = Color.Yellow;
		}

		private void ButtonBR1Set_Click(object sender, EventArgs e)
		{
			Module1.SetMax(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Add(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMaxRange.Value)));
			Module1.SetMin(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Subtract(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMinRange.Value)));
			Module1.SetStart(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
			this.ButtonBR1Set.Enabled = false;
			this.ButtonBR1Set.BackColor = Color.GreenYellow;
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			this.Rev2CurrentServo = 3;
			this.Rev2CurrentServoPosition = Convert.ToInt32(this.NumericUpDownInitialPosition.Value);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(this.NumericUpDownInitialPosition.Value));
			this.ButtonBR2Set.Enabled = true;
			this.ButtonBR2Set.BackColor = Color.Yellow;
		}

		private void ButtonBR2Set_Click(object sender, EventArgs e)
		{
			Module1.SetMax(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Add(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMaxRange.Value)));
			Module1.SetMin(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Subtract(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMinRange.Value)));
			Module1.SetStart(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
			this.ButtonBR2Set.Enabled = false;
			this.ButtonBR2Set.BackColor = Color.GreenYellow;
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			this.Rev2CurrentServo = 9;
			this.Rev2CurrentServoPosition = Convert.ToInt32(this.NumericUpDownInitialPosition.Value);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(this.NumericUpDownInitialPosition.Value));
			this.ButtonBR3Set.Enabled = true;
			this.ButtonBR3Set.BackColor = Color.Yellow;
		}

		private void ButtonBR3Set_Click(object sender, EventArgs e)
		{
			Module1.SetMax(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Add(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMaxRange.Value)));
			Module1.SetMin(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Subtract(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMinRange.Value)));
			Module1.SetStart(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
			this.ButtonBR3Set.Enabled = false;
			this.ButtonBR3Set.BackColor = Color.GreenYellow;
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			this.Rev2CurrentServo = 11;
			this.Rev2CurrentServoPosition = Convert.ToInt32(this.NumericUpDownInitialPosition.Value);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(this.NumericUpDownInitialPosition.Value));
			this.ButtonBR4Set.Enabled = true;
			this.ButtonBR4Set.BackColor = Color.Yellow;
		}

		private void ButtonBR4Set_Click(object sender, EventArgs e)
		{
			Module1.SetMax(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Add(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMaxRange.Value)));
			Module1.SetMin(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Subtract(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMinRange.Value)));
			Module1.SetStart(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
			this.ButtonBR4Set.Enabled = false;
			this.ButtonBR4Set.BackColor = Color.GreenYellow;
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			this.Rev2CurrentServo = 4;
			this.Rev2CurrentServoPosition = Convert.ToInt32(this.NumericUpDownInitialPosition.Value);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(this.NumericUpDownInitialPosition.Value));
			this.ButtonPL1Set.Enabled = true;
			this.ButtonPL1Set.BackColor = Color.Yellow;
		}

		private void ButtonCalAllMax_Click(object sender, EventArgs e)
		{
			this.ButtonCalAllMax.BackColor = Color.Yellow;
			this.ButtonSetMaxPosition.BackColor = Color.Yellow;
			this.ServoButtonColorRed();
			this.MoveAllMax();
			if (this.ButtonSetMinPosition.BackColor == Color.Yellow)
			{
				this.ButtonSetMinPosition.BackColor = Color.LightGray;
			}
			this.ButtonCommitSettings.BackColor = Color.Yellow;
			this.ButtonSetMinPosition.Enabled = false;
			this.ButtonSetMaxPosition.Enabled = true;
			this.VScrollBarCalibration.Value = 16383;
		}

		private void ButtonCalAllMin_Click(object sender, EventArgs e)
		{
			this.ButtonCalAllMin.BackColor = Color.Yellow;
			this.ButtonSetMinPosition.BackColor = Color.Yellow;
			this.ServoButtonColorRed();
			this.MoveAllMin();
			if (this.ButtonSetMaxPosition.BackColor == Color.Yellow)
			{
				this.ButtonSetMaxPosition.BackColor = Color.LightGray;
			}
			this.ButtonCommitSettings.BackColor = Color.Yellow;
			this.ButtonSetMinPosition.Enabled = true;
			this.ButtonSetMaxPosition.Enabled = false;
			this.VScrollBarCalibration.Value = 0;
		}

		private void ButtonCalServoDisableAll_Click(object sender, EventArgs e)
		{
			this.CalServoDisable();
			this.ButtonCalServoDisableAll.BackColor = Color.Red;
			this.ButtonCalServoEnableAll.BackColor = Color.LightGray;
		}

		private void ButtonCalServoEnableAll_Click(object sender, EventArgs e)
		{
			this.CalServoEnable();
			this.ButtonCalServoEnableAll.BackColor = Color.GreenYellow;
			this.ButtonCalServoDisableAll.BackColor = Color.LightGray;
		}

		private void ButtonColorReset()
		{
			this.ButtonServoBackLeft_1_S2.BackColor = Color.DarkGray;
			this.ButtonServoBackLeft_2_S0.BackColor = Color.DarkGray;
			this.ButtonServoBackLeft_3_S10.BackColor = Color.DarkGray;
			this.ButtonServoBackLeft_4_S8.BackColor = Color.DarkGray;
			this.ButtonServoBackRight_1_S1.BackColor = Color.DarkGray;
			this.ButtonServoBackRight_2_S3.BackColor = Color.DarkGray;
			this.ButtonServoBackRight_3_S9.BackColor = Color.DarkGray;
			this.ButtonServoBackRight_4_S11.BackColor = Color.DarkGray;
			this.ButtonServoPanLeft_1_S4.BackColor = Color.DarkGray;
			this.ButtonServoPanLeft_2_S6.BackColor = Color.DarkGray;
			this.ButtonServoPanLeft_3_S12.BackColor = Color.DarkGray;
			this.ButtonServoPanLeft_4_S14.BackColor = Color.DarkGray;
			this.ButtonServoPanRight_1_S7.BackColor = Color.DarkGray;
			this.ButtonServoPanRight_2_S5.BackColor = Color.DarkGray;
			this.ButtonServoPanRight_3_S15.BackColor = Color.DarkGray;
			this.ButtonServoPanRight_4_S13.BackColor = Color.DarkGray;
		}

		private void ButtonColorYellow()
		{
			this.ButtonServoBackLeft_1_S2.BackColor = Color.Yellow;
			this.ButtonServoBackLeft_4_S8.BackColor = Color.Yellow;
			this.ButtonServoBackRight_1_S1.BackColor = Color.Yellow;
			this.ButtonServoBackRight_2_S3.BackColor = Color.Yellow;
			this.ButtonServoBackRight_4_S11.BackColor = Color.Yellow;
			this.ButtonServoPanLeft_1_S4.BackColor = Color.Yellow;
			this.ButtonServoPanLeft_2_S6.BackColor = Color.Yellow;
			this.ButtonServoPanLeft_3_S12.BackColor = Color.Yellow;
			this.ButtonServoPanLeft_4_S14.BackColor = Color.Yellow;
			this.ButtonServoPanRight_1_S7.BackColor = Color.Yellow;
			this.ButtonServoPanRight_2_S5.BackColor = Color.Yellow;
			this.ButtonServoPanRight_3_S15.BackColor = Color.Yellow;
			this.ButtonServoPanRight_4_S13.BackColor = Color.Yellow;
		}

		private void ButtonCommit_Click(object sender, EventArgs e)
		{
			Module1.CommitSettings(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard);
			this.ButtonCommit.BackColor = Color.GreenYellow;
		}

		private void ButtonCommitSettings_Click(object sender, EventArgs e)
		{
			this.CalServoDisable();
			Module1.CommitSettings(this.sccom, this.scboard);
			this.ButtonCommitSettings.BackColor = Color.GreenYellow;
			this.ButtonCalServoEnableAll.BackColor = Color.Yellow;
			this.ButtonCalServoDisableAll.BackColor = Color.Red;
		}

		private void ButtonDecreaseCoarse_Click(object sender, EventArgs e)
		{
			this.Rev2CurrentServoPosition = Convert.ToInt32(decimal.Subtract(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownCoarse.Value));
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
		}

		private void ButtonDecreaseFine_Click(object sender, EventArgs e)
		{
			this.Rev2CurrentServoPosition = Convert.ToInt32(decimal.Subtract(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownFine.Value));
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
		}

		private void ButtonDisableAllServos_Click(object sender, EventArgs e)
		{
			this.CalServoDisable();
		}

		private void ButtonEnableAllServos_Click(object sender, EventArgs e)
		{
			this.CalServoEnable();
		}

		private void ButtonGoToCenterPosition_Click(object sender, EventArgs e)
		{
			Module1.QuickMoveRaw(this.sccom, this.scboard, this.CurrentServo, 8191);
			this.VScrollBarCalibration.Value = 8191;
		}

		private void ButtonIncreaseCoarse_Click(object sender, EventArgs e)
		{
			this.Rev2CurrentServoPosition = Convert.ToInt32(decimal.Add(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownCoarse.Value));
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
		}

		private void ButtonIncreaseFine_Click(object sender, EventArgs e)
		{
			this.Rev2CurrentServoPosition = Convert.ToInt32(decimal.Add(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownFine.Value));
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
		}

		private void ButtonInitCom_Click(object sender, EventArgs e)
		{
			Module1.InitPort(this.sccom, this.scbaud);
			this.ButtonInitCom.BackColor = Color.GreenYellow;
			this.ButtonCalServoEnableAll.BackColor = Color.Yellow;
		}

		private void ButtonMaxPosition_Click(object sender, EventArgs e)
		{
			Module1.QuickMoveRaw(this.sccom, this.scboard, this.CurrentServo, 16383);
			this.VScrollBarCalibration.Value = 16383;
		}

		private void ButtonMinPosition_Click(object sender, EventArgs e)
		{
			Module1.QuickMoveRaw(this.sccom, this.scboard, this.CurrentServo, 1);
			this.VScrollBarCalibration.Value = 1;
		}

		private void ButtonPL1Set_Click(object sender, EventArgs e)
		{
			Module1.SetMax(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Add(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMaxRange.Value)));
			Module1.SetMin(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Subtract(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMinRange.Value)));
			Module1.SetStart(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
			this.ButtonPL1Set.Enabled = false;
			this.ButtonPL1Set.BackColor = Color.GreenYellow;
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			this.Rev2CurrentServo = 6;
			this.Rev2CurrentServoPosition = Convert.ToInt32(this.NumericUpDownInitialPosition.Value);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(this.NumericUpDownInitialPosition.Value));
			this.ButtonPL2Set.Enabled = true;
			this.ButtonPL2Set.BackColor = Color.Yellow;
		}

		private void ButtonPL2Set_Click(object sender, EventArgs e)
		{
			Module1.SetMax(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Add(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMaxRange.Value)));
			Module1.SetMin(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Subtract(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMinRange.Value)));
			Module1.SetStart(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
			this.ButtonPL2Set.Enabled = false;
			this.ButtonPL2Set.BackColor = Color.GreenYellow;
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			this.Rev2CurrentServo = 12;
			this.Rev2CurrentServoPosition = Convert.ToInt32(this.NumericUpDownInitialPosition.Value);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(this.NumericUpDownInitialPosition.Value));
			this.ButtonPL3Set.Enabled = true;
			this.ButtonPL3Set.BackColor = Color.Yellow;
		}

		private void ButtonPL3Set_Click(object sender, EventArgs e)
		{
			Module1.SetMax(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Add(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMaxRange.Value)));
			Module1.SetMin(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Subtract(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMinRange.Value)));
			Module1.SetStart(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
			this.ButtonPL3Set.Enabled = false;
			this.ButtonPL3Set.BackColor = Color.GreenYellow;
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			this.Rev2CurrentServo = 14;
			this.Rev2CurrentServoPosition = Convert.ToInt32(this.NumericUpDownInitialPosition.Value);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(this.NumericUpDownInitialPosition.Value));
			this.ButtonPL4Set.Enabled = true;
			this.ButtonPL4Set.BackColor = Color.Yellow;
		}

		private void ButtonPL4Set_Click(object sender, EventArgs e)
		{
			Module1.SetMax(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Add(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMaxRange.Value)));
			Module1.SetMin(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Subtract(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMinRange.Value)));
			Module1.SetStart(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
			this.ButtonPL4Set.Enabled = false;
			this.ButtonPL4Set.BackColor = Color.GreenYellow;
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			this.Rev2CurrentServo = 7;
			this.Rev2CurrentServoPosition = Convert.ToInt32(this.NumericUpDownInitialPosition.Value);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(this.NumericUpDownInitialPosition.Value));
			this.ButtonPR1Set.Enabled = true;
			this.ButtonPR1Set.BackColor = Color.Yellow;
		}

		private void ButtonPR1Set_Click(object sender, EventArgs e)
		{
			Module1.SetMax(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Add(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMaxRange.Value)));
			Module1.SetMin(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Subtract(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMinRange.Value)));
			Module1.SetStart(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
			this.ButtonPR1Set.Enabled = false;
			this.ButtonPR1Set.BackColor = Color.GreenYellow;
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			this.Rev2CurrentServo = 5;
			this.Rev2CurrentServoPosition = Convert.ToInt32(this.NumericUpDownInitialPosition.Value);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(this.NumericUpDownInitialPosition.Value));
			this.ButtonPR2Set.Enabled = true;
			this.ButtonPR2Set.BackColor = Color.Yellow;
		}

		private void ButtonPR2Set_Click(object sender, EventArgs e)
		{
			Module1.SetMax(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Add(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMaxRange.Value)));
			Module1.SetMin(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Subtract(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMinRange.Value)));
			Module1.SetStart(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
			this.ButtonPR2Set.Enabled = false;
			this.ButtonPR2Set.BackColor = Color.GreenYellow;
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			this.Rev2CurrentServo = 15;
			this.Rev2CurrentServoPosition = Convert.ToInt32(this.NumericUpDownInitialPosition.Value);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(this.NumericUpDownInitialPosition.Value));
			this.ButtonPR3Set.Enabled = true;
			this.ButtonPR3Set.BackColor = Color.Yellow;
		}

		private void ButtonPR3Set_Click(object sender, EventArgs e)
		{
			Module1.SetMax(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Add(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMaxRange.Value)));
			Module1.SetMin(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Subtract(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMinRange.Value)));
			Module1.SetStart(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
			this.ButtonPR3Set.Enabled = false;
			this.ButtonPR3Set.BackColor = Color.GreenYellow;
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			this.Rev2CurrentServo = 13;
			this.Rev2CurrentServoPosition = Convert.ToInt32(this.NumericUpDownInitialPosition.Value);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(this.NumericUpDownInitialPosition.Value));
			this.ButtonPR4Set.Enabled = true;
			this.ButtonPR4Set.BackColor = Color.Yellow;
		}

		private void ButtonPR4Set_Click(object sender, EventArgs e)
		{
			Module1.SetMax(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Add(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMaxRange.Value)));
			Module1.SetMin(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(decimal.Subtract(new decimal(this.Rev2CurrentServoPosition), this.NumericUpDownMinRange.Value)));
			Module1.SetStart(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, this.Rev2CurrentServoPosition);
			this.ButtonPR4Set.Enabled = false;
			this.ButtonPR4Set.BackColor = Color.GreenYellow;
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
		}

		private void ButtonServoBackLeft_1_S2_Click(object sender, EventArgs e)
		{
			this.CurrentServoButton = "ButtonServoBackLeft_1_S2";
			this.CurrentServo = 2;
			this.CurrentPosition();
			if (this.ButtonServoBackLeft_1_S2.BackColor != Color.GreenYellow)
			{
				this.CheckCalButtonColor();
				this.ButtonServoBackLeft_1_S2.BackColor = Color.Yellow;
			}
		}

		private void ButtonServoBackLeft_2_S0_Click(object sender, EventArgs e)
		{
			this.VScrollBarCalibration.Value = this.CurrentServoValue;
			if (this.ButtonServoBackLeft_2_S0.BackColor != Color.GreenYellow)
			{
				this.CheckCalButtonColor();
				this.ButtonServoBackLeft_2_S0.BackColor = Color.Yellow;
				this.CurrentServo = 0;
				this.CurrentServoButton = "ButtonServoBackLeft_2_S0";
				this.CurrentPosition();
			}
		}

		private void ButtonServoBackLeft_3_S10_Click(object sender, EventArgs e)
		{
			this.VScrollBarCalibration.Value = this.CurrentServoValue;
			if (this.ButtonServoBackLeft_3_S10.BackColor != Color.GreenYellow)
			{
				this.CheckCalButtonColor();
				this.ButtonServoBackLeft_3_S10.BackColor = Color.Yellow;
				this.CurrentServo = 10;
				this.CurrentServoButton = "ButtonServoBackLeft_3_S10";
				this.CurrentPosition();
			}
		}

		private void ButtonServoBackLeft_4_S8_Click(object sender, EventArgs e)
		{
			if (this.ButtonServoBackLeft_4_S8.BackColor != Color.GreenYellow)
			{
				this.CheckCalButtonColor();
				this.ButtonServoBackLeft_4_S8.BackColor = Color.Yellow;
				this.CurrentServo = 8;
				this.CurrentServoButton = "ButtonServoBackLeft_4_S8";
				this.CurrentPosition();
			}
		}

		private void ButtonServoBackRight_1_S1_Click(object sender, EventArgs e)
		{
			if (this.ButtonServoBackRight_1_S1.BackColor != Color.GreenYellow)
			{
				this.CheckCalButtonColor();
				this.ButtonServoBackRight_1_S1.BackColor = Color.Yellow;
				this.CurrentServo = 1;
				this.CurrentServoButton = "ButtonServoBackRight_1_S1";
				this.CurrentPosition();
			}
		}

		private void ButtonServoBackRight_2_S3_Click(object sender, EventArgs e)
		{
			if (this.ButtonServoBackRight_2_S3.BackColor != Color.GreenYellow)
			{
				this.CheckCalButtonColor();
				this.ButtonServoBackRight_2_S3.BackColor = Color.Yellow;
				this.CurrentServo = 3;
				this.CurrentServoButton = "ButtonServoBackRight_2_S3";
				this.CurrentPosition();
			}
		}

		private void ButtonServoBackRight_3_S9_Click(object sender, EventArgs e)
		{
			if (this.ButtonServoBackRight_3_S9.BackColor != Color.GreenYellow)
			{
				this.CheckCalButtonColor();
				this.ButtonServoBackRight_3_S9.BackColor = Color.Yellow;
				this.CurrentServo = 9;
				this.CurrentServoButton = "ButtonServoBackRight_3_S9";
				this.CurrentPosition();
			}
		}

		private void ButtonServoBackRight_4_S11_Click(object sender, EventArgs e)
		{
			if (this.ButtonServoBackRight_4_S11.BackColor != Color.GreenYellow)
			{
				this.CheckCalButtonColor();
				this.ButtonServoBackRight_4_S11.BackColor = Color.Yellow;
				this.CurrentServo = 11;
				this.CurrentServoButton = "ButtonServoBackRight_4_S11";
				this.CurrentPosition();
			}
		}

		private void ButtonServoPanLeft_1_S4_Click(object sender, EventArgs e)
		{
			if (this.ButtonServoPanLeft_1_S4.BackColor != Color.GreenYellow)
			{
				this.CheckCalButtonColor();
				this.ButtonServoPanLeft_1_S4.BackColor = Color.Yellow;
				this.CurrentServo = 4;
				this.CurrentServoButton = "ButtonServoPanLeft_1_S4";
				this.CurrentPosition();
			}
		}

		private void ButtonServoPanLeft_2_S6_Click(object sender, EventArgs e)
		{
			if (this.ButtonServoPanLeft_2_S6.BackColor != Color.GreenYellow)
			{
				this.CheckCalButtonColor();
				this.ButtonServoPanLeft_2_S6.BackColor = Color.Yellow;
				this.CurrentServo = 6;
				this.CurrentServoButton = "ButtonServoPanLeft_2_S6";
				this.CurrentPosition();
			}
		}

		private void ButtonServoPanLeft_3_S12_Click(object sender, EventArgs e)
		{
			if (this.ButtonServoPanLeft_3_S12.BackColor != Color.GreenYellow)
			{
				this.CheckCalButtonColor();
				this.ButtonServoPanLeft_3_S12.BackColor = Color.Yellow;
				this.CurrentServo = 12;
				this.CurrentServoButton = "ButtonServoPanLeft_3_S12";
				this.CurrentPosition();
			}
		}

		private void ButtonServoPanLeft_4_S14_Click(object sender, EventArgs e)
		{
			if (this.ButtonServoPanLeft_4_S14.BackColor != Color.GreenYellow)
			{
				this.CheckCalButtonColor();
				this.ButtonServoPanLeft_4_S14.BackColor = Color.Yellow;
				this.CurrentServo = 14;
				this.CurrentServoButton = "ButtonServoPanLeft_4_S14";
				this.CurrentPosition();
			}
		}

		private void ButtonServoPanRight_1_S7_Click(object sender, EventArgs e)
		{
			if (this.ButtonServoPanRight_1_S7.BackColor != Color.GreenYellow)
			{
				this.CheckCalButtonColor();
				this.ButtonServoPanRight_1_S7.BackColor = Color.Yellow;
				this.CurrentServo = 7;
				this.CurrentServoButton = "ButtonServoPanRight_1_S7";
				this.CurrentPosition();
			}
		}

		private void ButtonServoPanRight_2_S5_Click(object sender, EventArgs e)
		{
			if (this.ButtonServoPanRight_2_S5.BackColor != Color.GreenYellow)
			{
				this.CheckCalButtonColor();
				this.ButtonServoPanRight_2_S5.BackColor = Color.Yellow;
				this.CurrentServo = 5;
				this.CurrentServoButton = "ButtonServoPanRight_2_S5";
				this.CurrentPosition();
			}
		}

		private void ButtonServoPanRight_3_S15_Click(object sender, EventArgs e)
		{
			if (this.ButtonServoPanRight_3_S15.BackColor != Color.GreenYellow)
			{
				this.CheckCalButtonColor();
				this.ButtonServoPanRight_3_S15.BackColor = Color.Yellow;
				this.CurrentServo = 15;
				this.CurrentServoButton = "ButtonServoPanRight_3_S15";
				this.CurrentPosition();
			}
		}

		private void ButtonServoPanRight_4_S13_Click(object sender, EventArgs e)
		{
			if (this.ButtonServoPanRight_4_S13.BackColor != Color.GreenYellow)
			{
				this.CheckCalButtonColor();
				this.ButtonServoPanRight_4_S13.BackColor = Color.Yellow;
				this.CurrentServo = 13;
				this.CurrentServoButton = "ButtonServoPanRight_4_S13";
				this.CurrentPosition();
			}
		}

		private void ButtonSetMaxPosition_Click(object sender, EventArgs e)
		{
			Module1.SetMaxCurrent(this.sccom, this.scboard, this.CurrentServo);
			this.TurnCurrentServoButtonGreen();
			this.ButtonSetMaxPosition.BackColor = Color.GreenYellow;
			this.CheckServoMaxCalFinished();
			if (this.VScrollBarCalibration.Value < 2 | this.VScrollBarCalibration.Value > 16380)
			{
				this.ButtonSetMaxPosition.BackColor = Color.Red;
			}
		}

		private void ButtonSetMinPosition_Click(object sender, EventArgs e)
		{
			Module1.SetMinCurrent(this.sccom, this.scboard, this.CurrentServo);
			this.TurnCurrentServoButtonGreen();
			this.ButtonSetMinPosition.BackColor = Color.GreenYellow;
			this.CheckServoMinCalFinished();
			if (this.VScrollBarCalibration.Value < 2 | this.VScrollBarCalibration.Value > 16380)
			{
				this.ButtonSetMinPosition.BackColor = Color.Red;
			}
		}

		private void ButtonStart_Click(object sender, EventArgs e)
		{
			Module1.InitPort(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scbaud);
			this.ButtonStart.BackColor = Color.GreenYellow;
			this.NumericUpDownCalRev2ComPort.BackColor = Color.GreenYellow;
			this.ButtonBL1Set.BackColor = Color.Yellow;
			this.ButtonStart.Enabled = false;
			this.NumericUpDownCalRev2ComPort.Enabled = false;
			this.ButtonBL1Set.Enabled = true;
			this.Rev2CurrentServoPosition = Convert.ToInt32(this.NumericUpDownInitialPosition.Value);
			this.Rev2CurrentServo = 2;
			Thread.Sleep(1000);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, this.Rev2CurrentServo, Convert.ToInt32(this.NumericUpDownInitialPosition.Value));
		}

		private void CalServoDisable()
		{
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 0);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 1);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 2);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 3);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 4);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 5);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 6);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 7);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 8);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 9);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 10);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 11);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 12);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 13);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 14);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 15);
		}

		private void CalServoEnable()
		{
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 0);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 1);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 2);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 3);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 4);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 5);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 6);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 7);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 8);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 9);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 10);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 11);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 12);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 13);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 14);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 15);
		}

		private void CheckCalButtonColor()
		{
			if (this.ButtonCalAllMin.BackColor == Color.Yellow)
			{
				this.ButtonSetMinPosition.BackColor = Color.Yellow;
				this.VScrollBarCalibration.Value = 0;
			}
			if (this.ButtonCalAllMax.BackColor == Color.Yellow)
			{
				this.ButtonSetMaxPosition.BackColor = Color.Yellow;
				this.VScrollBarCalibration.Value = 16383;
			}
		}

		private void CheckServoMaxCalFinished()
		{
			if ((this.ButtonServoBackLeft_1_S2.BackColor == Color.GreenYellow) & (this.ButtonServoBackLeft_2_S0.BackColor == Color.GreenYellow) & (this.ButtonServoBackLeft_3_S10.BackColor == Color.GreenYellow) & (this.ButtonServoBackLeft_4_S8.BackColor == Color.GreenYellow) & (this.ButtonServoBackRight_1_S1.BackColor == Color.GreenYellow) & (this.ButtonServoBackRight_2_S3.BackColor == Color.GreenYellow) & (this.ButtonServoBackRight_3_S9.BackColor == Color.GreenYellow) & (this.ButtonServoBackRight_4_S11.BackColor == Color.GreenYellow) & (this.ButtonServoPanLeft_1_S4.BackColor == Color.GreenYellow) & (this.ButtonServoPanLeft_2_S6.BackColor == Color.GreenYellow) & (this.ButtonServoPanLeft_3_S12.BackColor == Color.GreenYellow) & (this.ButtonServoPanLeft_4_S14.BackColor == Color.GreenYellow) & (this.ButtonServoPanRight_1_S7.BackColor == Color.GreenYellow) & (this.ButtonServoPanRight_2_S5.BackColor == Color.GreenYellow) & (this.ButtonServoPanRight_3_S15.BackColor == Color.GreenYellow) & (this.ButtonServoPanRight_4_S13.BackColor == Color.GreenYellow))
			{
				if (this.ButtonSetMaxPosition.BackColor == Color.GreenYellow)
				{
					this.ButtonCalAllMax.BackColor = Color.GreenYellow;
				}
			}
		}

		private void CheckServoMinCalFinished()
		{
			if ((this.ButtonServoBackLeft_1_S2.BackColor == Color.GreenYellow) & (this.ButtonServoBackLeft_2_S0.BackColor == Color.GreenYellow) & (this.ButtonServoBackLeft_3_S10.BackColor == Color.GreenYellow) & (this.ButtonServoBackLeft_4_S8.BackColor == Color.GreenYellow) & (this.ButtonServoBackRight_1_S1.BackColor == Color.GreenYellow) & (this.ButtonServoBackRight_2_S3.BackColor == Color.GreenYellow) & (this.ButtonServoBackRight_3_S9.BackColor == Color.GreenYellow) & (this.ButtonServoBackRight_4_S11.BackColor == Color.GreenYellow) & (this.ButtonServoPanLeft_1_S4.BackColor == Color.GreenYellow) & (this.ButtonServoPanLeft_2_S6.BackColor == Color.GreenYellow) & (this.ButtonServoPanLeft_3_S12.BackColor == Color.GreenYellow) & (this.ButtonServoPanLeft_4_S14.BackColor == Color.GreenYellow) & (this.ButtonServoPanRight_1_S7.BackColor == Color.GreenYellow) & (this.ButtonServoPanRight_2_S5.BackColor == Color.GreenYellow) & (this.ButtonServoPanRight_3_S15.BackColor == Color.GreenYellow) & (this.ButtonServoPanRight_4_S13.BackColor == Color.GreenYellow))
			{
				if (this.ButtonSetMinPosition.BackColor == Color.GreenYellow)
				{
					this.ButtonCalAllMin.BackColor = Color.GreenYellow;
				}
			}
		}

		private void CurrentPosition()
		{
			Module1.GetCurrentPositionRaw(this.sccom, this.scboard, this.CurrentServo, ref this.CurrentServoValue);
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool Disposing)
		{
			if (Disposing)
			{
				if (this.components != null)
				{
					this.components.Dispose();
				}
			}
			base.Dispose(Disposing);
		}

		private void frmMain_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
		{
			this.CalServoDisable();
			Module1.CloseAllComs();
		}

		private void frmMain_Load(object eventSender, EventArgs eventArgs)
		{
			this.scboard = 1;
			this.scbaud = 115200;
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.ToolTip1 = new ToolTip(this.components);
			this.Scroll_Renamed = new VScrollBarArray(this.components);
			this.TabControl1 = new TabControl();
			this.TabCalRev2 = new TabPage();
			this.ButtonCommit = new Button();
			this.Label26 = new Label();
			this.NumericUpDownMinRange = new NumericUpDown();
			this.Label25 = new Label();
			this.NumericUpDownMaxRange = new NumericUpDown();
			this.Label24 = new Label();
			this.NumericUpDownInitialPosition = new NumericUpDown();
			this.Label23 = new Label();
			this.Label22 = new Label();
			this.NumericUpDownFine = new NumericUpDown();
			this.NumericUpDownCoarse = new NumericUpDown();
			this.GroupBoxPanRight = new GroupBox();
			this.ButtonPR4Set = new Button();
			this.ButtonPR3Set = new Button();
			this.ButtonPR2Set = new Button();
			this.ButtonPR1Set = new Button();
			this.GroupBoxPanLeft = new GroupBox();
			this.ButtonPL4Set = new Button();
			this.ButtonPL3Set = new Button();
			this.ButtonPL2Set = new Button();
			this.ButtonPL1Set = new Button();
			this.GroupBoxBackRight = new GroupBox();
			this.ButtonBR4Set = new Button();
			this.ButtonBR3Set = new Button();
			this.ButtonBR2Set = new Button();
			this.ButtonBR1Set = new Button();
			this.ButtonDecreaseCoarse = new Button();
			this.ButtonDecreaseFine = new Button();
			this.ButtonIncreaseFine = new Button();
			this.ButtonIncreaseCoarse = new Button();
			this.GroupBoxBackLeft = new GroupBox();
			this.ButtonBL4Set = new Button();
			this.ButtonBL3Set = new Button();
			this.ButtonBL2Set = new Button();
			this.ButtonBL1Set = new Button();
			this.Label21 = new Label();
			this.NumericUpDownCalRev2ComPort = new NumericUpDown();
			this.ButtonStart = new Button();
			this.ShapeContainer1 = new ShapeContainer();
			this.LineShape3 = new LineShape();
			this.LineShape2 = new LineShape();
			this.LineShape1 = new LineShape();
			this.TabPanelMove = new TabPage();
			this.LabelPanPanelValueRight = new Label();
			this.LabelPanPanelValueLeft = new Label();
			this.LabelBackPanelValueRight = new Label();
			this.LabelBackPanelValueLeft = new Label();
			this.ButtonDisableAllServos = new Button();
			this.ButtonEnableAllServos = new Button();
			this.Label4 = new Label();
			this.VScrollBarPanLeftPanel = new VScrollBar();
			this.Label5 = new Label();
			this.VScrollBarPanRightPanel = new VScrollBar();
			this.Label3 = new Label();
			this.VScrollBarBackLeftPanel = new VScrollBar();
			this.Label2 = new Label();
			this.VScrollBarBackRightPanel = new VScrollBar();
			this.TabCalibration = new TabPage();
			this.ButtonCommitSettings = new Button();
			this.ButtonCalServoDisableAll = new Button();
			this.ButtonCalServoEnableAll = new Button();
			this.ButtonCalAllMax = new Button();
			this.ButtonCalAllMin = new Button();
			this.ButtonInitCom = new Button();
			this.NumericUpDownComPort = new NumericUpDown();
			this.VScrollBarCalibration = new VScrollBar();
			this.ButtonGoToCenterPosition = new Button();
			this.ButtonSetMinPosition = new Button();
			this.ButtonSetMaxPosition = new Button();
			this.ButtonMinPosition = new Button();
			this.ButtonMaxPosition = new Button();
			this.ButtonServoPanRight_4_S13 = new Button();
			this.ButtonServoPanRight_3_S15 = new Button();
			this.ButtonServoPanRight_2_S5 = new Button();
			this.ButtonServoPanRight_1_S7 = new Button();
			this.ButtonServoPanLeft_4_S14 = new Button();
			this.ButtonServoPanLeft_3_S12 = new Button();
			this.ButtonServoPanLeft_2_S6 = new Button();
			this.ButtonServoPanLeft_1_S4 = new Button();
			this.ButtonServoBackRight_4_S11 = new Button();
			this.ButtonServoBackRight_3_S9 = new Button();
			this.ButtonServoBackRight_2_S3 = new Button();
			this.ButtonServoBackRight_1_S1 = new Button();
			this.ButtonServoBackLeft_4_S8 = new Button();
			this.ButtonServoBackLeft_3_S10 = new Button();
			this.ButtonServoBackLeft_2_S0 = new Button();
			this.ButtonServoBackLeft_1_S2 = new Button();
			this.TabServoValues = new TabPage();
			this.TextBoxPR1 = new TextBox();
			this.TextBoxPR2 = new TextBox();
			this.TextBoxPR3 = new TextBox();
			this.TextBoxPR4 = new TextBox();
			this.TextBoxBR4 = new TextBox();
			this.TextBoxBR3 = new TextBox();
			this.TextBoxBR2 = new TextBox();
			this.TextBoxBR1 = new TextBox();
			this.TextBoxPL1 = new TextBox();
			this.TextBoxPL2 = new TextBox();
			this.TextBoxPL3 = new TextBox();
			this.TextBoxPL4 = new TextBox();
			this.TextBoxBL4 = new TextBox();
			this.TextBoxBL3 = new TextBox();
			this.TextBoxBL2 = new TextBox();
			this.TextBoxBL1 = new TextBox();
			this.Label13 = new Label();
			this.Label14 = new Label();
			this.Label15 = new Label();
			this.Label16 = new Label();
			this.Label17 = new Label();
			this.Label18 = new Label();
			this.Label19 = new Label();
			this.Label20 = new Label();
			this.Label7 = new Label();
			this.Label10 = new Label();
			this.Label11 = new Label();
			this.Label12 = new Label();
			this.Label9 = new Label();
			this.Label8 = new Label();
			this.LabelBL2Value = new Label();
			this.LabelBL1Value = new Label();
			this.TabPage1 = new TabPage();
			this.Label6 = new Label();
			this.Button1 = new Button();
			this._Scroll_10 = new VScrollBar();
			this._Scroll_0 = new VScrollBar();
			this.Label1 = new Label();
			this._Scroll_1 = new VScrollBar();
			this._Scroll_15 = new VScrollBar();
			this._Scroll_2 = new VScrollBar();
			this._Scroll_14 = new VScrollBar();
			this._Scroll_3 = new VScrollBar();
			this._Scroll_13 = new VScrollBar();
			this._Scroll_4 = new VScrollBar();
			this._Scroll_12 = new VScrollBar();
			this._Scroll_5 = new VScrollBar();
			this._Scroll_11 = new VScrollBar();
			this._Scroll_6 = new VScrollBar();
			this._Scroll_9 = new VScrollBar();
			this._Scroll_7 = new VScrollBar();
			this._Scroll_8 = new VScrollBar();
			((ISupportInitialize)this.Scroll_Renamed).BeginInit();
			this.TabControl1.SuspendLayout();
			this.TabCalRev2.SuspendLayout();
			((ISupportInitialize)this.NumericUpDownMinRange).BeginInit();
			((ISupportInitialize)this.NumericUpDownMaxRange).BeginInit();
			((ISupportInitialize)this.NumericUpDownInitialPosition).BeginInit();
			((ISupportInitialize)this.NumericUpDownFine).BeginInit();
			((ISupportInitialize)this.NumericUpDownCoarse).BeginInit();
			this.GroupBoxPanRight.SuspendLayout();
			this.GroupBoxPanLeft.SuspendLayout();
			this.GroupBoxBackRight.SuspendLayout();
			this.GroupBoxBackLeft.SuspendLayout();
			((ISupportInitialize)this.NumericUpDownCalRev2ComPort).BeginInit();
			this.TabPanelMove.SuspendLayout();
			this.TabCalibration.SuspendLayout();
			((ISupportInitialize)this.NumericUpDownComPort).BeginInit();
			this.TabServoValues.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.SuspendLayout();
			this.TabControl1.Controls.Add(this.TabCalRev2);
			this.TabControl1.Controls.Add(this.TabPanelMove);
			this.TabControl1.Controls.Add(this.TabCalibration);
			this.TabControl1.Controls.Add(this.TabServoValues);
			this.TabControl1.Controls.Add(this.TabPage1);
			TabControl tabControl1 = this.TabControl1;
			Point point = new Point(12, 12);
			tabControl1.Location = point;
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			TabControl tabControl = this.TabControl1;
			System.Drawing.Size size = new System.Drawing.Size(688, 598);
			tabControl.Size = size;
			this.TabControl1.TabIndex = 17;
			this.TabCalRev2.Controls.Add(this.ButtonCommit);
			this.TabCalRev2.Controls.Add(this.Label26);
			this.TabCalRev2.Controls.Add(this.NumericUpDownMinRange);
			this.TabCalRev2.Controls.Add(this.Label25);
			this.TabCalRev2.Controls.Add(this.NumericUpDownMaxRange);
			this.TabCalRev2.Controls.Add(this.Label24);
			this.TabCalRev2.Controls.Add(this.NumericUpDownInitialPosition);
			this.TabCalRev2.Controls.Add(this.Label23);
			this.TabCalRev2.Controls.Add(this.Label22);
			this.TabCalRev2.Controls.Add(this.NumericUpDownFine);
			this.TabCalRev2.Controls.Add(this.NumericUpDownCoarse);
			this.TabCalRev2.Controls.Add(this.GroupBoxPanRight);
			this.TabCalRev2.Controls.Add(this.GroupBoxPanLeft);
			this.TabCalRev2.Controls.Add(this.GroupBoxBackRight);
			this.TabCalRev2.Controls.Add(this.ButtonDecreaseCoarse);
			this.TabCalRev2.Controls.Add(this.ButtonDecreaseFine);
			this.TabCalRev2.Controls.Add(this.ButtonIncreaseFine);
			this.TabCalRev2.Controls.Add(this.ButtonIncreaseCoarse);
			this.TabCalRev2.Controls.Add(this.GroupBoxBackLeft);
			this.TabCalRev2.Controls.Add(this.Label21);
			this.TabCalRev2.Controls.Add(this.NumericUpDownCalRev2ComPort);
			this.TabCalRev2.Controls.Add(this.ButtonStart);
			this.TabCalRev2.Controls.Add(this.ShapeContainer1);
			TabPage tabCalRev2 = this.TabCalRev2;
			point = new Point(4, 25);
			tabCalRev2.Location = point;
			this.TabCalRev2.Name = "TabCalRev2";
			TabPage tabPage = this.TabCalRev2;
			System.Windows.Forms.Padding padding = new System.Windows.Forms.Padding(3);
			tabPage.Padding = padding;
			TabPage tabCalRev21 = this.TabCalRev2;
			size = new System.Drawing.Size(680, 569);
			tabCalRev21.Size = size;
			this.TabCalRev2.TabIndex = 4;
			this.TabCalRev2.Text = "Cal Rev 2";
			this.TabCalRev2.UseVisualStyleBackColor = true;
			this.ButtonCommit.BackColor = Color.Yellow;
			Button buttonCommit = this.ButtonCommit;
			point = new Point(15, 305);
			buttonCommit.Location = point;
			this.ButtonCommit.Name = "ButtonCommit";
			Button button = this.ButtonCommit;
			size = new System.Drawing.Size(133, 53);
			button.Size = size;
			this.ButtonCommit.TabIndex = 20;
			this.ButtonCommit.Text = "COMMIT";
			this.ButtonCommit.UseVisualStyleBackColor = false;
			this.Label26.AutoSize = true;
			this.Label26.Enabled = false;
			Label label26 = this.Label26;
			point = new Point(81, 218);
			label26.Location = point;
			this.Label26.Name = "Label26";
			Label label = this.Label26;
			size = new System.Drawing.Size(76, 16);
			label.Size = size;
			this.Label26.TabIndex = 19;
			this.Label26.Text = "Min Range";
			this.Label26.Visible = false;
			this.NumericUpDownMinRange.Enabled = false;
			NumericUpDown numericUpDownMinRange = this.NumericUpDownMinRange;
			point = new Point(15, 216);
			numericUpDownMinRange.Location = point;
			NumericUpDown numericUpDown = this.NumericUpDownMinRange;
			int[] numArray = new int[] { 10000, 0, 0, 0 };
			decimal num = new decimal(numArray);
			numericUpDown.Maximum = num;
			this.NumericUpDownMinRange.Name = "NumericUpDownMinRange";
			NumericUpDown numericUpDownMinRange1 = this.NumericUpDownMinRange;
			size = new System.Drawing.Size(60, 23);
			numericUpDownMinRange1.Size = size;
			this.NumericUpDownMinRange.TabIndex = 18;
			NumericUpDown numericUpDown1 = this.NumericUpDownMinRange;
			numArray = new int[] { 6000, 0, 0, 0 };
			num = new decimal(numArray);
			numericUpDown1.Value = num;
			this.NumericUpDownMinRange.Visible = false;
			this.Label25.AutoSize = true;
			this.Label25.Enabled = false;
			Label label25 = this.Label25;
			point = new Point(81, 189);
			label25.Location = point;
			this.Label25.Name = "Label25";
			Label label251 = this.Label25;
			size = new System.Drawing.Size(79, 16);
			label251.Size = size;
			this.Label25.TabIndex = 17;
			this.Label25.Text = "Max Range";
			this.Label25.Visible = false;
			this.NumericUpDownMaxRange.Enabled = false;
			NumericUpDown numericUpDownMaxRange = this.NumericUpDownMaxRange;
			point = new Point(15, 187);
			numericUpDownMaxRange.Location = point;
			NumericUpDown numericUpDownMaxRange1 = this.NumericUpDownMaxRange;
			numArray = new int[] { 10000, 0, 0, 0 };
			num = new decimal(numArray);
			numericUpDownMaxRange1.Maximum = num;
			this.NumericUpDownMaxRange.Name = "NumericUpDownMaxRange";
			NumericUpDown numericUpDownMaxRange2 = this.NumericUpDownMaxRange;
			size = new System.Drawing.Size(60, 23);
			numericUpDownMaxRange2.Size = size;
			this.NumericUpDownMaxRange.TabIndex = 16;
			NumericUpDown numericUpDown2 = this.NumericUpDownMaxRange;
			numArray = new int[] { 6000, 0, 0, 0 };
			num = new decimal(numArray);
			numericUpDown2.Value = num;
			this.NumericUpDownMaxRange.Visible = false;
			this.Label24.AutoSize = true;
			this.Label24.Enabled = false;
			Label label24 = this.Label24;
			point = new Point(81, 160);
			label24.Location = point;
			this.Label24.Name = "Label24";
			Label label241 = this.Label24;
			size = new System.Drawing.Size(54, 16);
			label241.Size = size;
			this.Label24.TabIndex = 15;
			this.Label24.Text = "Init Pos";
			this.Label24.Visible = false;
			this.NumericUpDownInitialPosition.Enabled = false;
			NumericUpDown numericUpDownInitialPosition = this.NumericUpDownInitialPosition;
			point = new Point(15, 158);
			numericUpDownInitialPosition.Location = point;
			NumericUpDown numericUpDownInitialPosition1 = this.NumericUpDownInitialPosition;
			numArray = new int[] { 10000, 0, 0, 0 };
			num = new decimal(numArray);
			numericUpDownInitialPosition1.Maximum = num;
			this.NumericUpDownInitialPosition.Name = "NumericUpDownInitialPosition";
			NumericUpDown numericUpDownInitialPosition2 = this.NumericUpDownInitialPosition;
			size = new System.Drawing.Size(60, 23);
			numericUpDownInitialPosition2.Size = size;
			this.NumericUpDownInitialPosition.TabIndex = 14;
			NumericUpDown numericUpDownInitialPosition3 = this.NumericUpDownInitialPosition;
			numArray = new int[] { 8000, 0, 0, 0 };
			num = new decimal(numArray);
			numericUpDownInitialPosition3.Value = num;
			this.NumericUpDownInitialPosition.Visible = false;
			this.Label23.AutoSize = true;
			this.Label23.Enabled = false;
			Label label23 = this.Label23;
			point = new Point(81, 131);
			label23.Location = point;
			this.Label23.Name = "Label23";
			Label label231 = this.Label23;
			size = new System.Drawing.Size(36, 16);
			label231.Size = size;
			this.Label23.TabIndex = 13;
			this.Label23.Text = "Fine";
			this.Label23.Visible = false;
			this.Label22.AutoSize = true;
			this.Label22.Enabled = false;
			Label label22 = this.Label22;
			point = new Point(81, 102);
			label22.Location = point;
			this.Label22.Name = "Label22";
			Label label221 = this.Label22;
			size = new System.Drawing.Size(54, 16);
			label221.Size = size;
			this.Label22.TabIndex = 12;
			this.Label22.Text = "Coarse";
			this.Label22.Visible = false;
			this.NumericUpDownFine.Enabled = false;
			NumericUpDown numericUpDownFine = this.NumericUpDownFine;
			point = new Point(15, 129);
			numericUpDownFine.Location = point;
			this.NumericUpDownFine.Name = "NumericUpDownFine";
			NumericUpDown numericUpDownFine1 = this.NumericUpDownFine;
			size = new System.Drawing.Size(60, 23);
			numericUpDownFine1.Size = size;
			this.NumericUpDownFine.TabIndex = 11;
			NumericUpDown numericUpDownFine2 = this.NumericUpDownFine;
			numArray = new int[] { 50, 0, 0, 0 };
			num = new decimal(numArray);
			numericUpDownFine2.Value = num;
			this.NumericUpDownFine.Visible = false;
			this.NumericUpDownCoarse.Enabled = false;
			NumericUpDown numericUpDownCoarse = this.NumericUpDownCoarse;
			point = new Point(15, 100);
			numericUpDownCoarse.Location = point;
			NumericUpDown numericUpDownCoarse1 = this.NumericUpDownCoarse;
			numArray = new int[] { 1000, 0, 0, 0 };
			num = new decimal(numArray);
			numericUpDownCoarse1.Maximum = num;
			this.NumericUpDownCoarse.Name = "NumericUpDownCoarse";
			NumericUpDown numericUpDownCoarse2 = this.NumericUpDownCoarse;
			size = new System.Drawing.Size(60, 23);
			numericUpDownCoarse2.Size = size;
			this.NumericUpDownCoarse.TabIndex = 10;
			NumericUpDown numericUpDownCoarse3 = this.NumericUpDownCoarse;
			numArray = new int[] { 200, 0, 0, 0 };
			num = new decimal(numArray);
			numericUpDownCoarse3.Value = num;
			this.NumericUpDownCoarse.Visible = false;
			this.GroupBoxPanRight.Controls.Add(this.ButtonPR4Set);
			this.GroupBoxPanRight.Controls.Add(this.ButtonPR3Set);
			this.GroupBoxPanRight.Controls.Add(this.ButtonPR2Set);
			this.GroupBoxPanRight.Controls.Add(this.ButtonPR1Set);
			GroupBox groupBoxPanRight = this.GroupBoxPanRight;
			point = new Point(367, 364);
			groupBoxPanRight.Location = point;
			this.GroupBoxPanRight.Name = "GroupBoxPanRight";
			GroupBox groupBox = this.GroupBoxPanRight;
			size = new System.Drawing.Size(185, 184);
			groupBox.Size = size;
			this.GroupBoxPanRight.TabIndex = 9;
			this.GroupBoxPanRight.TabStop = false;
			this.GroupBoxPanRight.Text = "PAN RIGHT";
			this.ButtonPR4Set.Enabled = false;
			Button buttonPR4Set = this.ButtonPR4Set;
			point = new Point(6, 139);
			buttonPR4Set.Location = point;
			this.ButtonPR4Set.Name = "ButtonPR4Set";
			Button buttonPR4Set1 = this.ButtonPR4Set;
			size = new System.Drawing.Size(173, 33);
			buttonPR4Set1.Size = size;
			this.ButtonPR4Set.TabIndex = 7;
			this.ButtonPR4Set.Text = "PR4 SET";
			this.ButtonPR4Set.UseVisualStyleBackColor = true;
			this.ButtonPR3Set.Enabled = false;
			Button buttonPR3Set = this.ButtonPR3Set;
			point = new Point(6, 100);
			buttonPR3Set.Location = point;
			this.ButtonPR3Set.Name = "ButtonPR3Set";
			Button buttonPR3Set1 = this.ButtonPR3Set;
			size = new System.Drawing.Size(173, 33);
			buttonPR3Set1.Size = size;
			this.ButtonPR3Set.TabIndex = 6;
			this.ButtonPR3Set.Text = "PR3 SET";
			this.ButtonPR3Set.UseVisualStyleBackColor = true;
			this.ButtonPR2Set.Enabled = false;
			Button buttonPR2Set = this.ButtonPR2Set;
			point = new Point(6, 61);
			buttonPR2Set.Location = point;
			this.ButtonPR2Set.Name = "ButtonPR2Set";
			Button buttonPR2Set1 = this.ButtonPR2Set;
			size = new System.Drawing.Size(173, 33);
			buttonPR2Set1.Size = size;
			this.ButtonPR2Set.TabIndex = 5;
			this.ButtonPR2Set.Text = "PR2 SET";
			this.ButtonPR2Set.UseVisualStyleBackColor = true;
			this.ButtonPR1Set.Enabled = false;
			Button buttonPR1Set = this.ButtonPR1Set;
			point = new Point(6, 22);
			buttonPR1Set.Location = point;
			this.ButtonPR1Set.Name = "ButtonPR1Set";
			Button buttonPR1Set1 = this.ButtonPR1Set;
			size = new System.Drawing.Size(173, 33);
			buttonPR1Set1.Size = size;
			this.ButtonPR1Set.TabIndex = 4;
			this.ButtonPR1Set.Text = "PR1 SET";
			this.ButtonPR1Set.UseVisualStyleBackColor = true;
			this.GroupBoxPanLeft.Controls.Add(this.ButtonPL4Set);
			this.GroupBoxPanLeft.Controls.Add(this.ButtonPL3Set);
			this.GroupBoxPanLeft.Controls.Add(this.ButtonPL2Set);
			this.GroupBoxPanLeft.Controls.Add(this.ButtonPL1Set);
			GroupBox groupBoxPanLeft = this.GroupBoxPanLeft;
			point = new Point(176, 364);
			groupBoxPanLeft.Location = point;
			this.GroupBoxPanLeft.Name = "GroupBoxPanLeft";
			GroupBox groupBoxPanLeft1 = this.GroupBoxPanLeft;
			size = new System.Drawing.Size(185, 184);
			groupBoxPanLeft1.Size = size;
			this.GroupBoxPanLeft.TabIndex = 8;
			this.GroupBoxPanLeft.TabStop = false;
			this.GroupBoxPanLeft.Text = "PAN LEFT";
			this.ButtonPL4Set.Enabled = false;
			Button buttonPL4Set = this.ButtonPL4Set;
			point = new Point(7, 139);
			buttonPL4Set.Location = point;
			this.ButtonPL4Set.Name = "ButtonPL4Set";
			Button buttonPL4Set1 = this.ButtonPL4Set;
			size = new System.Drawing.Size(173, 33);
			buttonPL4Set1.Size = size;
			this.ButtonPL4Set.TabIndex = 7;
			this.ButtonPL4Set.Text = "PL4 SET";
			this.ButtonPL4Set.UseVisualStyleBackColor = true;
			this.ButtonPL3Set.Enabled = false;
			Button buttonPL3Set = this.ButtonPL3Set;
			point = new Point(7, 100);
			buttonPL3Set.Location = point;
			this.ButtonPL3Set.Name = "ButtonPL3Set";
			Button buttonPL3Set1 = this.ButtonPL3Set;
			size = new System.Drawing.Size(173, 33);
			buttonPL3Set1.Size = size;
			this.ButtonPL3Set.TabIndex = 6;
			this.ButtonPL3Set.Text = "PL3 SET";
			this.ButtonPL3Set.UseVisualStyleBackColor = true;
			this.ButtonPL2Set.Enabled = false;
			Button buttonPL2Set = this.ButtonPL2Set;
			point = new Point(7, 61);
			buttonPL2Set.Location = point;
			this.ButtonPL2Set.Name = "ButtonPL2Set";
			Button buttonPL2Set1 = this.ButtonPL2Set;
			size = new System.Drawing.Size(173, 33);
			buttonPL2Set1.Size = size;
			this.ButtonPL2Set.TabIndex = 5;
			this.ButtonPL2Set.Text = "PL2 SET";
			this.ButtonPL2Set.UseVisualStyleBackColor = true;
			this.ButtonPL1Set.Enabled = false;
			Button buttonPL1Set = this.ButtonPL1Set;
			point = new Point(6, 22);
			buttonPL1Set.Location = point;
			this.ButtonPL1Set.Name = "ButtonPL1Set";
			Button buttonPL1Set1 = this.ButtonPL1Set;
			size = new System.Drawing.Size(173, 33);
			buttonPL1Set1.Size = size;
			this.ButtonPL1Set.TabIndex = 4;
			this.ButtonPL1Set.Text = "PL1 SET";
			this.ButtonPL1Set.UseVisualStyleBackColor = true;
			this.GroupBoxBackRight.Controls.Add(this.ButtonBR4Set);
			this.GroupBoxBackRight.Controls.Add(this.ButtonBR3Set);
			this.GroupBoxBackRight.Controls.Add(this.ButtonBR2Set);
			this.GroupBoxBackRight.Controls.Add(this.ButtonBR1Set);
			GroupBox groupBoxBackRight = this.GroupBoxBackRight;
			point = new Point(367, 119);
			groupBoxBackRight.Location = point;
			this.GroupBoxBackRight.Name = "GroupBoxBackRight";
			GroupBox groupBoxBackRight1 = this.GroupBoxBackRight;
			size = new System.Drawing.Size(185, 180);
			groupBoxBackRight1.Size = size;
			this.GroupBoxBackRight.TabIndex = 8;
			this.GroupBoxBackRight.TabStop = false;
			this.GroupBoxBackRight.Text = "BACK RIGHT";
			this.ButtonBR4Set.Enabled = false;
			Button buttonBR4Set = this.ButtonBR4Set;
			point = new Point(6, 139);
			buttonBR4Set.Location = point;
			this.ButtonBR4Set.Name = "ButtonBR4Set";
			Button buttonBR4Set1 = this.ButtonBR4Set;
			size = new System.Drawing.Size(173, 33);
			buttonBR4Set1.Size = size;
			this.ButtonBR4Set.TabIndex = 7;
			this.ButtonBR4Set.Text = "BR4 SET";
			this.ButtonBR4Set.UseVisualStyleBackColor = true;
			this.ButtonBR3Set.Enabled = false;
			Button buttonBR3Set = this.ButtonBR3Set;
			point = new Point(6, 100);
			buttonBR3Set.Location = point;
			this.ButtonBR3Set.Name = "ButtonBR3Set";
			Button buttonBR3Set1 = this.ButtonBR3Set;
			size = new System.Drawing.Size(173, 33);
			buttonBR3Set1.Size = size;
			this.ButtonBR3Set.TabIndex = 6;
			this.ButtonBR3Set.Text = "BR3 SET";
			this.ButtonBR3Set.UseVisualStyleBackColor = true;
			this.ButtonBR2Set.Enabled = false;
			Button buttonBR2Set = this.ButtonBR2Set;
			point = new Point(6, 61);
			buttonBR2Set.Location = point;
			this.ButtonBR2Set.Name = "ButtonBR2Set";
			Button buttonBR2Set1 = this.ButtonBR2Set;
			size = new System.Drawing.Size(173, 33);
			buttonBR2Set1.Size = size;
			this.ButtonBR2Set.TabIndex = 5;
			this.ButtonBR2Set.Text = "BR2 SET";
			this.ButtonBR2Set.UseVisualStyleBackColor = true;
			this.ButtonBR1Set.Enabled = false;
			Button buttonBR1Set = this.ButtonBR1Set;
			point = new Point(6, 22);
			buttonBR1Set.Location = point;
			this.ButtonBR1Set.Name = "ButtonBR1Set";
			Button buttonBR1Set1 = this.ButtonBR1Set;
			size = new System.Drawing.Size(173, 33);
			buttonBR1Set1.Size = size;
			this.ButtonBR1Set.TabIndex = 4;
			this.ButtonBR1Set.Text = "BR1 SET";
			this.ButtonBR1Set.UseVisualStyleBackColor = true;
			this.ButtonDecreaseCoarse.Enabled = false;
			this.ButtonDecreaseCoarse.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button buttonDecreaseCoarse = this.ButtonDecreaseCoarse;
			point = new Point(176, 305);
			buttonDecreaseCoarse.Location = point;
			this.ButtonDecreaseCoarse.Name = "ButtonDecreaseCoarse";
			Button buttonDecreaseCoarse1 = this.ButtonDecreaseCoarse;
			size = new System.Drawing.Size(45, 53);
			buttonDecreaseCoarse1.Size = size;
			this.ButtonDecreaseCoarse.TabIndex = 9;
			this.ButtonDecreaseCoarse.Text = "<<";
			this.ButtonDecreaseCoarse.UseVisualStyleBackColor = true;
			this.ButtonDecreaseCoarse.Visible = false;
			this.ButtonDecreaseFine.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button buttonDecreaseFine = this.ButtonDecreaseFine;
			point = new Point(373, 305);
			buttonDecreaseFine.Location = point;
			this.ButtonDecreaseFine.Name = "ButtonDecreaseFine";
			Button buttonDecreaseFine1 = this.ButtonDecreaseFine;
			size = new System.Drawing.Size(75, 53);
			buttonDecreaseFine1.Size = size;
			this.ButtonDecreaseFine.TabIndex = 8;
			this.ButtonDecreaseFine.Text = "<";
			this.ButtonDecreaseFine.UseVisualStyleBackColor = true;
			this.ButtonIncreaseFine.Enabled = false;
			this.ButtonIncreaseFine.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button buttonIncreaseFine = this.ButtonIncreaseFine;
			point = new Point(227, 305);
			buttonIncreaseFine.Location = point;
			this.ButtonIncreaseFine.Name = "ButtonIncreaseFine";
			Button buttonIncreaseFine1 = this.ButtonIncreaseFine;
			size = new System.Drawing.Size(45, 53);
			buttonIncreaseFine1.Size = size;
			this.ButtonIncreaseFine.TabIndex = 7;
			this.ButtonIncreaseFine.Text = ">";
			this.ButtonIncreaseFine.UseVisualStyleBackColor = true;
			this.ButtonIncreaseFine.Visible = false;
			this.ButtonIncreaseCoarse.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button buttonIncreaseCoarse = this.ButtonIncreaseCoarse;
			point = new Point(477, 305);
			buttonIncreaseCoarse.Location = point;
			this.ButtonIncreaseCoarse.Name = "ButtonIncreaseCoarse";
			Button buttonIncreaseCoarse1 = this.ButtonIncreaseCoarse;
			size = new System.Drawing.Size(75, 53);
			buttonIncreaseCoarse1.Size = size;
			this.ButtonIncreaseCoarse.TabIndex = 6;
			this.ButtonIncreaseCoarse.Text = ">>";
			this.ButtonIncreaseCoarse.UseVisualStyleBackColor = true;
			this.GroupBoxBackLeft.Controls.Add(this.ButtonBL4Set);
			this.GroupBoxBackLeft.Controls.Add(this.ButtonBL3Set);
			this.GroupBoxBackLeft.Controls.Add(this.ButtonBL2Set);
			this.GroupBoxBackLeft.Controls.Add(this.ButtonBL1Set);
			GroupBox groupBoxBackLeft = this.GroupBoxBackLeft;
			point = new Point(176, 119);
			groupBoxBackLeft.Location = point;
			this.GroupBoxBackLeft.Name = "GroupBoxBackLeft";
			GroupBox groupBoxBackLeft1 = this.GroupBoxBackLeft;
			size = new System.Drawing.Size(185, 180);
			groupBoxBackLeft1.Size = size;
			this.GroupBoxBackLeft.TabIndex = 5;
			this.GroupBoxBackLeft.TabStop = false;
			this.GroupBoxBackLeft.Text = "BACK LEFT";
			this.ButtonBL4Set.Enabled = false;
			Button buttonBL4Set = this.ButtonBL4Set;
			point = new Point(7, 139);
			buttonBL4Set.Location = point;
			this.ButtonBL4Set.Name = "ButtonBL4Set";
			Button buttonBL4Set1 = this.ButtonBL4Set;
			size = new System.Drawing.Size(173, 33);
			buttonBL4Set1.Size = size;
			this.ButtonBL4Set.TabIndex = 7;
			this.ButtonBL4Set.Text = "BL4 SET";
			this.ButtonBL4Set.UseVisualStyleBackColor = true;
			this.ButtonBL3Set.Enabled = false;
			Button buttonBL3Set = this.ButtonBL3Set;
			point = new Point(7, 100);
			buttonBL3Set.Location = point;
			this.ButtonBL3Set.Name = "ButtonBL3Set";
			Button buttonBL3Set1 = this.ButtonBL3Set;
			size = new System.Drawing.Size(173, 33);
			buttonBL3Set1.Size = size;
			this.ButtonBL3Set.TabIndex = 6;
			this.ButtonBL3Set.Text = "BL3 SET";
			this.ButtonBL3Set.UseVisualStyleBackColor = true;
			this.ButtonBL2Set.Enabled = false;
			Button buttonBL2Set = this.ButtonBL2Set;
			point = new Point(7, 61);
			buttonBL2Set.Location = point;
			this.ButtonBL2Set.Name = "ButtonBL2Set";
			Button buttonBL2Set1 = this.ButtonBL2Set;
			size = new System.Drawing.Size(173, 33);
			buttonBL2Set1.Size = size;
			this.ButtonBL2Set.TabIndex = 5;
			this.ButtonBL2Set.Text = "BL2 SET";
			this.ButtonBL2Set.UseVisualStyleBackColor = true;
			this.ButtonBL1Set.Enabled = false;
			Button buttonBL1Set = this.ButtonBL1Set;
			point = new Point(6, 22);
			buttonBL1Set.Location = point;
			this.ButtonBL1Set.Name = "ButtonBL1Set";
			Button buttonBL1Set1 = this.ButtonBL1Set;
			size = new System.Drawing.Size(173, 33);
			buttonBL1Set1.Size = size;
			this.ButtonBL1Set.TabIndex = 4;
			this.ButtonBL1Set.Text = "BL1 SET";
			this.ButtonBL1Set.UseVisualStyleBackColor = true;
			this.Label21.AutoSize = true;
			this.Label21.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label21 = this.Label21;
			point = new Point(2, 50);
			label21.Location = point;
			this.Label21.Name = "Label21";
			Label label211 = this.Label21;
			size = new System.Drawing.Size(57, 24);
			label211.Size = size;
			this.Label21.TabIndex = 2;
			this.Label21.Text = "COM";
			this.NumericUpDownCalRev2ComPort.BackColor = Color.Yellow;
			this.NumericUpDownCalRev2ComPort.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			NumericUpDown numericUpDownCalRev2ComPort = this.NumericUpDownCalRev2ComPort;
			point = new Point(65, 48);
			numericUpDownCalRev2ComPort.Location = point;
			NumericUpDown numericUpDownCalRev2ComPort1 = this.NumericUpDownCalRev2ComPort;
			numArray = new int[] { 200, 0, 0, 0 };
			num = new decimal(numArray);
			numericUpDownCalRev2ComPort1.Maximum = num;
			this.NumericUpDownCalRev2ComPort.Name = "NumericUpDownCalRev2ComPort";
			NumericUpDown numericUpDownCalRev2ComPort2 = this.NumericUpDownCalRev2ComPort;
			size = new System.Drawing.Size(65, 30);
			numericUpDownCalRev2ComPort2.Size = size;
			this.NumericUpDownCalRev2ComPort.TabIndex = 1;
			NumericUpDown numericUpDownCalRev2ComPort3 = this.NumericUpDownCalRev2ComPort;
			numArray = new int[] { 84, 0, 0, 0 };
			num = new decimal(numArray);
			numericUpDownCalRev2ComPort3.Value = num;
			this.ButtonStart.BackColor = Color.Yellow;
			this.ButtonStart.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Button buttonStart = this.ButtonStart;
			point = new Point(6, 6);
			buttonStart.Location = point;
			this.ButtonStart.Name = "ButtonStart";
			Button buttonStart1 = this.ButtonStart;
			size = new System.Drawing.Size(124, 38);
			buttonStart1.Size = size;
			this.ButtonStart.TabIndex = 0;
			this.ButtonStart.Text = "START";
			this.ButtonStart.UseVisualStyleBackColor = false;
			ShapeContainer shapeContainer1 = this.ShapeContainer1;
			point = new Point(3, 3);
			shapeContainer1.Location = point;
			ShapeContainer shapeContainer = this.ShapeContainer1;
			padding = new System.Windows.Forms.Padding(0);
			shapeContainer.Margin = padding;
			this.ShapeContainer1.Name = "ShapeContainer1";
			ShapeCollection shapes = this.ShapeContainer1.Shapes;
			Shape[] lineShape3 = new Shape[] { this.LineShape3, this.LineShape2, this.LineShape1 };
			shapes.AddRange(lineShape3);
			ShapeContainer shapeContainer11 = this.ShapeContainer1;
			size = new System.Drawing.Size(674, 563);
			shapeContainer11.Size = size;
			this.ShapeContainer1.TabIndex = 3;
			this.ShapeContainer1.TabStop = false;
			this.LineShape3.Name = "LineShape3";
			this.LineShape3.X1=249;
			this.LineShape3.X2=460;
			this.LineShape3.Y1=24;
			this.LineShape3.Y2=24;
			this.LineShape2.Name="LineShape2";
			this.LineShape2.X1 = 460;
			this.LineShape2.X2=546;
			this.LineShape2.Y1=24;
			this.LineShape2.Y2=117;
			this.LineShape1.Name="LineShape1";
			this.LineShape1.X1=248;
			this.LineShape1.X2=174;
			this.LineShape1.Y1=24;
			this.LineShape1.Y2=119;
			this.TabPanelMove.Controls.Add(this.LabelPanPanelValueRight);
			this.TabPanelMove.Controls.Add(this.LabelPanPanelValueLeft);
			this.TabPanelMove.Controls.Add(this.LabelBackPanelValueRight);
			this.TabPanelMove.Controls.Add(this.LabelBackPanelValueLeft);
			this.TabPanelMove.Controls.Add(this.ButtonDisableAllServos);
			this.TabPanelMove.Controls.Add(this.ButtonEnableAllServos);
			this.TabPanelMove.Controls.Add(this.Label4);
			this.TabPanelMove.Controls.Add(this.VScrollBarPanLeftPanel);
			this.TabPanelMove.Controls.Add(this.Label5);
			this.TabPanelMove.Controls.Add(this.VScrollBarPanRightPanel);
			this.TabPanelMove.Controls.Add(this.Label3);
			this.TabPanelMove.Controls.Add(this.VScrollBarBackLeftPanel);
			this.TabPanelMove.Controls.Add(this.Label2);
			this.TabPanelMove.Controls.Add(this.VScrollBarBackRightPanel);
			TabPage tabPanelMove = this.TabPanelMove;
			point = new Point(4, 25);
			tabPanelMove.Location = point;
			this.TabPanelMove.Name = "TabPanelMove";
			TabPage tabPanelMove1 = this.TabPanelMove;
			padding = new System.Windows.Forms.Padding(3);
			tabPanelMove1.Padding = padding;
			TabPage tabPage1 = this.TabPanelMove;
			size = new System.Drawing.Size(680, 569);
			tabPage1.Size = size;
			this.TabPanelMove.TabIndex = 1;
			this.TabPanelMove.Text = "Panel Move";
			this.TabPanelMove.UseVisualStyleBackColor = true;
			this.LabelPanPanelValueRight.AutoSize = true;
			this.LabelPanPanelValueRight.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label labelPanPanelValueRight = this.LabelPanPanelValueRight;
			point = new Point(481, 389);
			labelPanPanelValueRight.Location = point;
			this.LabelPanPanelValueRight.Name = "LabelPanPanelValueRight";
			Label labelPanPanelValueRight1 = this.LabelPanPanelValueRight;
			size = new System.Drawing.Size(32, 24);
			labelPanPanelValueRight1.Size = size;
			this.LabelPanPanelValueRight.TabIndex = 13;
			this.LabelPanPanelValueRight.Text = "50";
			this.LabelPanPanelValueLeft.AutoSize = true;
			this.LabelPanPanelValueLeft.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label labelPanPanelValueLeft = this.LabelPanPanelValueLeft;
			point = new Point(236, 389);
			labelPanPanelValueLeft.Location = point;
			this.LabelPanPanelValueLeft.Name = "LabelPanPanelValueLeft";
			Label labelPanPanelValueLeft1 = this.LabelPanPanelValueLeft;
			size = new System.Drawing.Size(32, 24);
			labelPanPanelValueLeft1.Size = size;
			this.LabelPanPanelValueLeft.TabIndex = 12;
			this.LabelPanPanelValueLeft.Text = "50";
			this.LabelBackPanelValueRight.AutoSize = true;
			this.LabelBackPanelValueRight.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label labelBackPanelValueRight = this.LabelBackPanelValueRight;
			point = new Point(481, 162);
			labelBackPanelValueRight.Location = point;
			this.LabelBackPanelValueRight.Name = "LabelBackPanelValueRight";
			Label labelBackPanelValueRight1 = this.LabelBackPanelValueRight;
			size = new System.Drawing.Size(32, 24);
			labelBackPanelValueRight1.Size = size;
			this.LabelBackPanelValueRight.TabIndex = 11;
			this.LabelBackPanelValueRight.Text = "50";
			this.LabelBackPanelValueLeft.AutoSize = true;
			this.LabelBackPanelValueLeft.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label labelBackPanelValueLeft = this.LabelBackPanelValueLeft;
			point = new Point(236, 162);
			labelBackPanelValueLeft.Location = point;
			this.LabelBackPanelValueLeft.Name = "LabelBackPanelValueLeft";
			Label labelBackPanelValueLeft1 = this.LabelBackPanelValueLeft;
			size = new System.Drawing.Size(32, 24);
			labelBackPanelValueLeft1.Size = size;
			this.LabelBackPanelValueLeft.TabIndex = 10;
			this.LabelBackPanelValueLeft.Text = "50";
			this.ButtonDisableAllServos.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button buttonDisableAllServos = this.ButtonDisableAllServos;
			point = new Point(24, 205);
			buttonDisableAllServos.Location = point;
			this.ButtonDisableAllServos.Name = "ButtonDisableAllServos";
			Button buttonDisableAllServos1 = this.ButtonDisableAllServos;
			size = new System.Drawing.Size(75, 73);
			buttonDisableAllServos1.Size = size;
			this.ButtonDisableAllServos.TabIndex = 9;
			this.ButtonDisableAllServos.Text = "Disable All Servos";
			this.ButtonDisableAllServos.UseVisualStyleBackColor = true;
			this.ButtonEnableAllServos.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button buttonEnableAllServos = this.ButtonEnableAllServos;
			point = new Point(24, 96);
			buttonEnableAllServos.Location = point;
			this.ButtonEnableAllServos.Name = "ButtonEnableAllServos";
			Button buttonEnableAllServos1 = this.ButtonEnableAllServos;
			size = new System.Drawing.Size(75, 73);
			buttonEnableAllServos1.Size = size;
			this.ButtonEnableAllServos.TabIndex = 8;
			this.ButtonEnableAllServos.Text = "Enable All Servos";
			this.ButtonEnableAllServos.UseVisualStyleBackColor = true;
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label4 = this.Label4;
			point = new Point(122, 287);
			label4.Location = point;
			this.Label4.Name = "Label4";
			Label label41 = this.Label4;
			size = new System.Drawing.Size(147, 24);
			label41.Size = size;
			this.Label4.TabIndex = 7;
			this.Label4.Text = "Pan Left Panel";
			VScrollBar vScrollBarPanLeftPanel = this.VScrollBarPanLeftPanel;
			point = new Point(172, 318);
			vScrollBarPanLeftPanel.Location = point;
			this.VScrollBarPanLeftPanel.Maximum = 109;
			this.VScrollBarPanLeftPanel.Minimum = 1;
			this.VScrollBarPanLeftPanel.Name = "VScrollBarPanLeftPanel";
			VScrollBar vScrollBar = this.VScrollBarPanLeftPanel;
			size = new System.Drawing.Size(40, 161);
			vScrollBar.Size = size;
			this.VScrollBarPanLeftPanel.TabIndex = 6;
			this.VScrollBarPanLeftPanel.Value = 50;
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label5 = this.Label5;
			point = new Point(361, 287);
			label5.Location = point;
			this.Label5.Name = "Label5";
			Label label51 = this.Label5;
			size = new System.Drawing.Size(160, 24);
			label51.Size = size;
			this.Label5.TabIndex = 5;
			this.Label5.Text = "Pan Right Panel";
			VScrollBar vScrollBarPanRightPanel = this.VScrollBarPanRightPanel;
			point = new Point(411, 318);
			vScrollBarPanRightPanel.Location = point;
			this.VScrollBarPanRightPanel.Maximum = 109;
			this.VScrollBarPanRightPanel.Minimum = 1;
			this.VScrollBarPanRightPanel.Name = "VScrollBarPanRightPanel";
			VScrollBar vScrollBarPanRightPanel1 = this.VScrollBarPanRightPanel;
			size = new System.Drawing.Size(40, 161);
			vScrollBarPanRightPanel1.Size = size;
			this.VScrollBarPanRightPanel.TabIndex = 4;
			this.VScrollBarPanRightPanel.Value = 50;
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label3 = this.Label3;
			point = new Point(122, 54);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label31 = this.Label3;
			size = new System.Drawing.Size(158, 24);
			label31.Size = size;
			this.Label3.TabIndex = 3;
			this.Label3.Text = "Back Left Panel";
			VScrollBar vScrollBarBackLeftPanel = this.VScrollBarBackLeftPanel;
			point = new Point(172, 85);
			vScrollBarBackLeftPanel.Location = point;
			this.VScrollBarBackLeftPanel.Maximum = 109;
			this.VScrollBarBackLeftPanel.Minimum = 1;
			this.VScrollBarBackLeftPanel.Name = "VScrollBarBackLeftPanel";
			VScrollBar vScrollBarBackLeftPanel1 = this.VScrollBarBackLeftPanel;
			size = new System.Drawing.Size(40, 161);
			vScrollBarBackLeftPanel1.Size = size;
			this.VScrollBarBackLeftPanel.TabIndex = 2;
			this.VScrollBarBackLeftPanel.Value = 50;
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label2 = this.Label2;
			point = new Point(361, 54);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label1 = this.Label2;
			size = new System.Drawing.Size(171, 24);
			label1.Size = size;
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Back Right Panel";
			VScrollBar vScrollBarBackRightPanel = this.VScrollBarBackRightPanel;
			point = new Point(411, 85);
			vScrollBarBackRightPanel.Location = point;
			this.VScrollBarBackRightPanel.Maximum = 109;
			this.VScrollBarBackRightPanel.Minimum = 1;
			this.VScrollBarBackRightPanel.Name = "VScrollBarBackRightPanel";
			VScrollBar vScrollBarBackRightPanel1 = this.VScrollBarBackRightPanel;
			size = new System.Drawing.Size(40, 161);
			vScrollBarBackRightPanel1.Size = size;
			this.VScrollBarBackRightPanel.TabIndex = 0;
			this.VScrollBarBackRightPanel.Value = 50;
			this.TabCalibration.Controls.Add(this.ButtonCommitSettings);
			this.TabCalibration.Controls.Add(this.ButtonCalServoDisableAll);
			this.TabCalibration.Controls.Add(this.ButtonCalServoEnableAll);
			this.TabCalibration.Controls.Add(this.ButtonCalAllMax);
			this.TabCalibration.Controls.Add(this.ButtonCalAllMin);
			this.TabCalibration.Controls.Add(this.ButtonInitCom);
			this.TabCalibration.Controls.Add(this.NumericUpDownComPort);
			this.TabCalibration.Controls.Add(this.VScrollBarCalibration);
			this.TabCalibration.Controls.Add(this.ButtonGoToCenterPosition);
			this.TabCalibration.Controls.Add(this.ButtonSetMinPosition);
			this.TabCalibration.Controls.Add(this.ButtonSetMaxPosition);
			this.TabCalibration.Controls.Add(this.ButtonMinPosition);
			this.TabCalibration.Controls.Add(this.ButtonMaxPosition);
			this.TabCalibration.Controls.Add(this.ButtonServoPanRight_4_S13);
			this.TabCalibration.Controls.Add(this.ButtonServoPanRight_3_S15);
			this.TabCalibration.Controls.Add(this.ButtonServoPanRight_2_S5);
			this.TabCalibration.Controls.Add(this.ButtonServoPanRight_1_S7);
			this.TabCalibration.Controls.Add(this.ButtonServoPanLeft_4_S14);
			this.TabCalibration.Controls.Add(this.ButtonServoPanLeft_3_S12);
			this.TabCalibration.Controls.Add(this.ButtonServoPanLeft_2_S6);
			this.TabCalibration.Controls.Add(this.ButtonServoPanLeft_1_S4);
			this.TabCalibration.Controls.Add(this.ButtonServoBackRight_4_S11);
			this.TabCalibration.Controls.Add(this.ButtonServoBackRight_3_S9);
			this.TabCalibration.Controls.Add(this.ButtonServoBackRight_2_S3);
			this.TabCalibration.Controls.Add(this.ButtonServoBackRight_1_S1);
			this.TabCalibration.Controls.Add(this.ButtonServoBackLeft_4_S8);
			this.TabCalibration.Controls.Add(this.ButtonServoBackLeft_3_S10);
			this.TabCalibration.Controls.Add(this.ButtonServoBackLeft_2_S0);
			this.TabCalibration.Controls.Add(this.ButtonServoBackLeft_1_S2);
			TabPage tabCalibration = this.TabCalibration;
			point = new Point(4, 25);
			tabCalibration.Location = point;
			this.TabCalibration.Name = "TabCalibration";
			TabPage tabCalibration1 = this.TabCalibration;
			padding = new System.Windows.Forms.Padding(3);
			tabCalibration1.Padding = padding;
			TabPage tabCalibration2 = this.TabCalibration;
			size = new System.Drawing.Size(680, 569);
			tabCalibration2.Size = size;
			this.TabCalibration.TabIndex = 0;
			this.TabCalibration.Text = "Calibration";
			this.TabCalibration.UseVisualStyleBackColor = true;
			this.ButtonCommitSettings.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button buttonCommitSettings = this.ButtonCommitSettings;
			point = new Point(6, 240);
			buttonCommitSettings.Location = point;
			this.ButtonCommitSettings.Name = "ButtonCommitSettings";
			Button buttonCommitSettings1 = this.ButtonCommitSettings;
			size = new System.Drawing.Size(141, 78);
			buttonCommitSettings1.Size = size;
			this.ButtonCommitSettings.TabIndex = 30;
			this.ButtonCommitSettings.Text = "Commit Settings";
			this.ButtonCommitSettings.UseVisualStyleBackColor = true;
			this.ButtonCommitSettings.Visible = false;
			this.ButtonCalServoDisableAll.BackColor = SystemColors.Control;
			this.ButtonCalServoDisableAll.Font = new System.Drawing.Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Button buttonCalServoDisableAll = this.ButtonCalServoDisableAll;
			point = new Point(184, 56);
			buttonCalServoDisableAll.Location = point;
			this.ButtonCalServoDisableAll.Name = "ButtonCalServoDisableAll";
			Button buttonCalServoDisableAll1 = this.ButtonCalServoDisableAll;
			size = new System.Drawing.Size(64, 44);
			buttonCalServoDisableAll1.Size = size;
			this.ButtonCalServoDisableAll.TabIndex = 29;
			this.ButtonCalServoDisableAll.Text = "Disable All Servos";
			this.ButtonCalServoDisableAll.UseVisualStyleBackColor = false;
			this.ButtonCalServoDisableAll.Visible = false;
			this.ButtonCalServoEnableAll.Font = new System.Drawing.Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Button buttonCalServoEnableAll = this.ButtonCalServoEnableAll;
			point = new Point(184, 6);
			buttonCalServoEnableAll.Location = point;
			this.ButtonCalServoEnableAll.Name = "ButtonCalServoEnableAll";
			Button buttonCalServoEnableAll1 = this.ButtonCalServoEnableAll;
			size = new System.Drawing.Size(64, 44);
			buttonCalServoEnableAll1.Size = size;
			this.ButtonCalServoEnableAll.TabIndex = 28;
			this.ButtonCalServoEnableAll.Text = "Enable All Servos";
			this.ButtonCalServoEnableAll.UseVisualStyleBackColor = true;
			this.ButtonCalServoEnableAll.Visible = false;
			this.ButtonCalAllMax.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button buttonCalAllMax = this.ButtonCalAllMax;
			point = new Point(6, 442);
			buttonCalAllMax.Location = point;
			this.ButtonCalAllMax.Name = "ButtonCalAllMax";
			Button buttonCalAllMax1 = this.ButtonCalAllMax;
			size = new System.Drawing.Size(141, 78);
			buttonCalAllMax1.Size = size;
			this.ButtonCalAllMax.TabIndex = 27;
			this.ButtonCalAllMax.Text = "Calibrate MAX Positions";
			this.ButtonCalAllMax.UseVisualStyleBackColor = true;
			this.ButtonCalAllMax.Visible = false;
			this.ButtonCalAllMin.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button buttonCalAllMin = this.ButtonCalAllMin;
			point = new Point(6, 58);
			buttonCalAllMin.Location = point;
			this.ButtonCalAllMin.Name = "ButtonCalAllMin";
			Button buttonCalAllMin1 = this.ButtonCalAllMin;
			size = new System.Drawing.Size(141, 78);
			buttonCalAllMin1.Size = size;
			this.ButtonCalAllMin.TabIndex = 26;
			this.ButtonCalAllMin.Text = "Calibrate MIN Positions";
			this.ButtonCalAllMin.UseVisualStyleBackColor = true;
			this.ButtonCalAllMin.Visible = false;
			this.ButtonInitCom.BackColor = Color.Yellow;
			this.ButtonInitCom.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button buttonInitCom = this.ButtonInitCom;
			point = new Point(6, 6);
			buttonInitCom.Location = point;
			this.ButtonInitCom.Name = "ButtonInitCom";
			Button buttonInitCom1 = this.ButtonInitCom;
			size = new System.Drawing.Size(98, 46);
			buttonInitCom1.Size = size;
			this.ButtonInitCom.TabIndex = 25;
			this.ButtonInitCom.Text = "Initialize Com Port";
			this.ButtonInitCom.UseVisualStyleBackColor = false;
			this.ButtonInitCom.Visible = false;
			this.NumericUpDownComPort.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			NumericUpDown numericUpDownComPort = this.NumericUpDownComPort;
			point = new Point(110, 16);
			numericUpDownComPort.Location = point;
			NumericUpDown numericUpDownComPort1 = this.NumericUpDownComPort;
			numArray = new int[] { 222, 0, 0, 0 };
			num = new decimal(numArray);
			numericUpDownComPort1.Maximum = num;
			this.NumericUpDownComPort.Name = "NumericUpDownComPort";
			NumericUpDown numericUpDownComPort2 = this.NumericUpDownComPort;
			size = new System.Drawing.Size(55, 30);
			numericUpDownComPort2.Size = size;
			this.NumericUpDownComPort.TabIndex = 23;
			NumericUpDown numericUpDownComPort3 = this.NumericUpDownComPort;
			numArray = new int[] { 74, 0, 0, 0 };
			num = new decimal(numArray);
			numericUpDownComPort3.Value = num;
			this.NumericUpDownComPort.Visible = false;
			this.VScrollBarCalibration.Cursor = Cursors.Default;
			this.VScrollBarCalibration.LargeChange = 200;
			VScrollBar vScrollBarCalibration = this.VScrollBarCalibration;
			point = new Point(472, 132);
			vScrollBarCalibration.Location = point;
			this.VScrollBarCalibration.Maximum = 16383;
			this.VScrollBarCalibration.Name = "VScrollBarCalibration";
			VScrollBar vScrollBarCalibration1 = this.VScrollBarCalibration;
			size = new System.Drawing.Size(41, 257);
			vScrollBarCalibration1.Size = size;
			this.VScrollBarCalibration.SmallChange = 50;
			this.VScrollBarCalibration.TabIndex = 22;
			this.VScrollBarCalibration.TabStop = true;
			this.VScrollBarCalibration.Value = 16383;
			this.VScrollBarCalibration.Visible = false;
			Button buttonGoToCenterPosition = this.ButtonGoToCenterPosition;
			point = new Point(293, 31);
			buttonGoToCenterPosition.Location = point;
			this.ButtonGoToCenterPosition.Name = "ButtonGoToCenterPosition";
			Button buttonGoToCenterPosition1 = this.ButtonGoToCenterPosition;
			size = new System.Drawing.Size(51, 42);
			buttonGoToCenterPosition1.Size = size;
			this.ButtonGoToCenterPosition.TabIndex = 21;
			this.ButtonGoToCenterPosition.Text = "Go To Center";
			this.ButtonGoToCenterPosition.UseVisualStyleBackColor = true;
			this.ButtonGoToCenterPosition.Visible = false;
			this.ButtonSetMinPosition.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button buttonSetMinPosition = this.ButtonSetMinPosition;
			point = new Point(420, 31);
			buttonSetMinPosition.Location = point;
			this.ButtonSetMinPosition.Name = "ButtonSetMinPosition";
			Button buttonSetMinPosition1 = this.ButtonSetMinPosition;
			size = new System.Drawing.Size(141, 65);
			buttonSetMinPosition1.Size = size;
			this.ButtonSetMinPosition.TabIndex = 20;
			this.ButtonSetMinPosition.Text = "Set MIN Position";
			this.ButtonSetMinPosition.UseVisualStyleBackColor = true;
			this.ButtonSetMinPosition.Visible = false;
			this.ButtonSetMaxPosition.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button buttonSetMaxPosition = this.ButtonSetMaxPosition;
			point = new Point(420, 425);
			buttonSetMaxPosition.Location = point;
			this.ButtonSetMaxPosition.Name = "ButtonSetMaxPosition";
			Button buttonSetMaxPosition1 = this.ButtonSetMaxPosition;
			size = new System.Drawing.Size(141, 65);
			buttonSetMaxPosition1.Size = size;
			this.ButtonSetMaxPosition.TabIndex = 19;
			this.ButtonSetMaxPosition.Text = "Set Max Position";
			this.ButtonSetMaxPosition.UseVisualStyleBackColor = true;
			this.ButtonSetMaxPosition.Visible = false;
			Button buttonMinPosition = this.ButtonMinPosition;
			point = new Point(449, 102);
			buttonMinPosition.Location = point;
			this.ButtonMinPosition.Name = "ButtonMinPosition";
			Button buttonMinPosition1 = this.ButtonMinPosition;
			size = new System.Drawing.Size(85, 27);
			buttonMinPosition1.Size = size;
			this.ButtonMinPosition.TabIndex = 18;
			this.ButtonMinPosition.Text = "Go To MIN";
			this.ButtonMinPosition.UseVisualStyleBackColor = true;
			this.ButtonMinPosition.Visible = false;
			Button buttonMaxPosition = this.ButtonMaxPosition;
			point = new Point(449, 395);
			buttonMaxPosition.Location = point;
			this.ButtonMaxPosition.Name = "ButtonMaxPosition";
			Button buttonMaxPosition1 = this.ButtonMaxPosition;
			size = new System.Drawing.Size(85, 24);
			buttonMaxPosition1.Size = size;
			this.ButtonMaxPosition.TabIndex = 17;
			this.ButtonMaxPosition.Text = "Go To MAX";
			this.ButtonMaxPosition.UseVisualStyleBackColor = true;
			this.ButtonMaxPosition.Visible = false;
			this.ButtonServoPanRight_4_S13.BackColor = Color.DarkGray;
			Button buttonServoPanRight4S13 = this.ButtonServoPanRight_4_S13;
			point = new Point(525, 366);
			buttonServoPanRight4S13.Location = point;
			this.ButtonServoPanRight_4_S13.Name = "ButtonServoPanRight_4_S13";
			Button buttonServoPanRight4S131 = this.ButtonServoPanRight_4_S13;
			size = new System.Drawing.Size(106, 23);
			buttonServoPanRight4S131.Size = size;
			this.ButtonServoPanRight_4_S13.TabIndex = 15;
			this.ButtonServoPanRight_4_S13.Text = "Pan Right 4 - S13";
			this.ButtonServoPanRight_4_S13.UseVisualStyleBackColor = false;
			this.ButtonServoPanRight_4_S13.Visible = false;
			this.ButtonServoPanRight_3_S15.BackColor = Color.DarkGray;
			Button buttonServoPanRight3S15 = this.ButtonServoPanRight_3_S15;
			point = new Point(525, 337);
			buttonServoPanRight3S15.Location = point;
			this.ButtonServoPanRight_3_S15.Name = "ButtonServoPanRight_3_S15";
			Button buttonServoPanRight3S151 = this.ButtonServoPanRight_3_S15;
			size = new System.Drawing.Size(106, 23);
			buttonServoPanRight3S151.Size = size;
			this.ButtonServoPanRight_3_S15.TabIndex = 14;
			this.ButtonServoPanRight_3_S15.Text = "Pan Right 3 - S15";
			this.ButtonServoPanRight_3_S15.UseVisualStyleBackColor = false;
			this.ButtonServoPanRight_3_S15.Visible = false;
			this.ButtonServoPanRight_2_S5.BackColor = Color.DarkGray;
			Button buttonServoPanRight2S5 = this.ButtonServoPanRight_2_S5;
			point = new Point(525, 308);
			buttonServoPanRight2S5.Location = point;
			this.ButtonServoPanRight_2_S5.Name = "ButtonServoPanRight_2_S5";
			Button buttonServoPanRight2S51 = this.ButtonServoPanRight_2_S5;
			size = new System.Drawing.Size(106, 23);
			buttonServoPanRight2S51.Size = size;
			this.ButtonServoPanRight_2_S5.TabIndex = 13;
			this.ButtonServoPanRight_2_S5.Text = "Pan Right 2 - S5";
			this.ButtonServoPanRight_2_S5.UseVisualStyleBackColor = false;
			this.ButtonServoPanRight_2_S5.Visible = false;
			this.ButtonServoPanRight_1_S7.BackColor = Color.DarkGray;
			Button buttonServoPanRight1S7 = this.ButtonServoPanRight_1_S7;
			point = new Point(525, 279);
			buttonServoPanRight1S7.Location = point;
			this.ButtonServoPanRight_1_S7.Name = "ButtonServoPanRight_1_S7";
			Button buttonServoPanRight1S71 = this.ButtonServoPanRight_1_S7;
			size = new System.Drawing.Size(106, 23);
			buttonServoPanRight1S71.Size = size;
			this.ButtonServoPanRight_1_S7.TabIndex = 12;
			this.ButtonServoPanRight_1_S7.Text = "Pan Right 1 - S7";
			this.ButtonServoPanRight_1_S7.UseVisualStyleBackColor = false;
			this.ButtonServoPanRight_1_S7.Visible = false;
			this.ButtonServoPanLeft_4_S14.BackColor = Color.DarkGray;
			Button buttonServoPanLeft4S14 = this.ButtonServoPanLeft_4_S14;
			point = new Point(354, 366);
			buttonServoPanLeft4S14.Location = point;
			this.ButtonServoPanLeft_4_S14.Name = "ButtonServoPanLeft_4_S14";
			Button buttonServoPanLeft4S141 = this.ButtonServoPanLeft_4_S14;
			size = new System.Drawing.Size(106, 23);
			buttonServoPanLeft4S141.Size = size;
			this.ButtonServoPanLeft_4_S14.TabIndex = 11;
			this.ButtonServoPanLeft_4_S14.Text = "Pan Left 4 - S14";
			this.ButtonServoPanLeft_4_S14.UseVisualStyleBackColor = false;
			this.ButtonServoPanLeft_4_S14.Visible = false;
			this.ButtonServoPanLeft_3_S12.BackColor = Color.DarkGray;
			Button buttonServoPanLeft3S12 = this.ButtonServoPanLeft_3_S12;
			point = new Point(354, 337);
			buttonServoPanLeft3S12.Location = point;
			this.ButtonServoPanLeft_3_S12.Name = "ButtonServoPanLeft_3_S12";
			Button buttonServoPanLeft3S121 = this.ButtonServoPanLeft_3_S12;
			size = new System.Drawing.Size(106, 23);
			buttonServoPanLeft3S121.Size = size;
			this.ButtonServoPanLeft_3_S12.TabIndex = 10;
			this.ButtonServoPanLeft_3_S12.Text = "Pan Left 3 - S12";
			this.ButtonServoPanLeft_3_S12.UseVisualStyleBackColor = false;
			this.ButtonServoPanLeft_3_S12.Visible = false;
			this.ButtonServoPanLeft_2_S6.BackColor = Color.DarkGray;
			Button buttonServoPanLeft2S6 = this.ButtonServoPanLeft_2_S6;
			point = new Point(354, 308);
			buttonServoPanLeft2S6.Location = point;
			this.ButtonServoPanLeft_2_S6.Name = "ButtonServoPanLeft_2_S6";
			Button buttonServoPanLeft2S61 = this.ButtonServoPanLeft_2_S6;
			size = new System.Drawing.Size(106, 23);
			buttonServoPanLeft2S61.Size = size;
			this.ButtonServoPanLeft_2_S6.TabIndex = 9;
			this.ButtonServoPanLeft_2_S6.Text = "Pan Left 2 - S6";
			this.ButtonServoPanLeft_2_S6.UseVisualStyleBackColor = false;
			this.ButtonServoPanLeft_2_S6.Visible = false;
			this.ButtonServoPanLeft_1_S4.BackColor = Color.DarkGray;
			Button buttonServoPanLeft1S4 = this.ButtonServoPanLeft_1_S4;
			point = new Point(354, 279);
			buttonServoPanLeft1S4.Location = point;
			this.ButtonServoPanLeft_1_S4.Name = "ButtonServoPanLeft_1_S4";
			Button buttonServoPanLeft1S41 = this.ButtonServoPanLeft_1_S4;
			size = new System.Drawing.Size(106, 23);
			buttonServoPanLeft1S41.Size = size;
			this.ButtonServoPanLeft_1_S4.TabIndex = 8;
			this.ButtonServoPanLeft_1_S4.Text = "Pan Left 1 - S4";
			this.ButtonServoPanLeft_1_S4.UseVisualStyleBackColor = false;
			this.ButtonServoPanLeft_1_S4.Visible = false;
			this.ButtonServoBackRight_4_S11.BackColor = Color.DarkGray;
			Button buttonServoBackRight4S11 = this.ButtonServoBackRight_4_S11;
			point = new Point(525, 219);
			buttonServoBackRight4S11.Location = point;
			this.ButtonServoBackRight_4_S11.Name = "ButtonServoBackRight_4_S11";
			Button buttonServoBackRight4S111 = this.ButtonServoBackRight_4_S11;
			size = new System.Drawing.Size(106, 23);
			buttonServoBackRight4S111.Size = size;
			this.ButtonServoBackRight_4_S11.TabIndex = 7;
			this.ButtonServoBackRight_4_S11.Text = "Back Right 4 - S11";
			this.ButtonServoBackRight_4_S11.UseVisualStyleBackColor = false;
			this.ButtonServoBackRight_4_S11.Visible = false;
			this.ButtonServoBackRight_3_S9.BackColor = Color.DarkGray;
			Button buttonServoBackRight3S9 = this.ButtonServoBackRight_3_S9;
			point = new Point(525, 190);
			buttonServoBackRight3S9.Location = point;
			this.ButtonServoBackRight_3_S9.Name = "ButtonServoBackRight_3_S9";
			Button buttonServoBackRight3S91 = this.ButtonServoBackRight_3_S9;
			size = new System.Drawing.Size(106, 23);
			buttonServoBackRight3S91.Size = size;
			this.ButtonServoBackRight_3_S9.TabIndex = 6;
			this.ButtonServoBackRight_3_S9.Text = "Back Right 3 - S9";
			this.ButtonServoBackRight_3_S9.UseVisualStyleBackColor = false;
			this.ButtonServoBackRight_3_S9.Visible = false;
			this.ButtonServoBackRight_2_S3.BackColor = Color.DarkGray;
			Button buttonServoBackRight2S3 = this.ButtonServoBackRight_2_S3;
			point = new Point(525, 161);
			buttonServoBackRight2S3.Location = point;
			this.ButtonServoBackRight_2_S3.Name = "ButtonServoBackRight_2_S3";
			Button buttonServoBackRight2S31 = this.ButtonServoBackRight_2_S3;
			size = new System.Drawing.Size(106, 23);
			buttonServoBackRight2S31.Size = size;
			this.ButtonServoBackRight_2_S3.TabIndex = 5;
			this.ButtonServoBackRight_2_S3.Text = "Back Right 2 - S3";
			this.ButtonServoBackRight_2_S3.UseVisualStyleBackColor = false;
			this.ButtonServoBackRight_2_S3.Visible = false;
			this.ButtonServoBackRight_1_S1.BackColor = Color.DarkGray;
			Button buttonServoBackRight1S1 = this.ButtonServoBackRight_1_S1;
			point = new Point(525, 132);
			buttonServoBackRight1S1.Location = point;
			this.ButtonServoBackRight_1_S1.Name = "ButtonServoBackRight_1_S1";
			Button buttonServoBackRight1S11 = this.ButtonServoBackRight_1_S1;
			size = new System.Drawing.Size(106, 23);
			buttonServoBackRight1S11.Size = size;
			this.ButtonServoBackRight_1_S1.TabIndex = 4;
			this.ButtonServoBackRight_1_S1.Text = "Back Right 1 - S1";
			this.ButtonServoBackRight_1_S1.UseVisualStyleBackColor = false;
			this.ButtonServoBackRight_1_S1.Visible = false;
			this.ButtonServoBackLeft_4_S8.BackColor = Color.DarkGray;
			Button buttonServoBackLeft4S8 = this.ButtonServoBackLeft_4_S8;
			point = new Point(354, 219);
			buttonServoBackLeft4S8.Location = point;
			this.ButtonServoBackLeft_4_S8.Name = "ButtonServoBackLeft_4_S8";
			Button buttonServoBackLeft4S81 = this.ButtonServoBackLeft_4_S8;
			size = new System.Drawing.Size(106, 23);
			buttonServoBackLeft4S81.Size = size;
			this.ButtonServoBackLeft_4_S8.TabIndex = 3;
			this.ButtonServoBackLeft_4_S8.Text = "Back Left 4 - S8";
			this.ButtonServoBackLeft_4_S8.UseVisualStyleBackColor = false;
			this.ButtonServoBackLeft_4_S8.Visible = false;
			this.ButtonServoBackLeft_3_S10.BackColor = Color.DarkGray;
			Button buttonServoBackLeft3S10 = this.ButtonServoBackLeft_3_S10;
			point = new Point(354, 190);
			buttonServoBackLeft3S10.Location = point;
			this.ButtonServoBackLeft_3_S10.Name = "ButtonServoBackLeft_3_S10";
			Button buttonServoBackLeft3S101 = this.ButtonServoBackLeft_3_S10;
			size = new System.Drawing.Size(106, 23);
			buttonServoBackLeft3S101.Size = size;
			this.ButtonServoBackLeft_3_S10.TabIndex = 2;
			this.ButtonServoBackLeft_3_S10.Text = "Back Left 3 - S10";
			this.ButtonServoBackLeft_3_S10.UseVisualStyleBackColor = false;
			this.ButtonServoBackLeft_3_S10.Visible = false;
			this.ButtonServoBackLeft_2_S0.BackColor = Color.DarkGray;
			Button buttonServoBackLeft2S0 = this.ButtonServoBackLeft_2_S0;
			point = new Point(354, 161);
			buttonServoBackLeft2S0.Location = point;
			this.ButtonServoBackLeft_2_S0.Name = "ButtonServoBackLeft_2_S0";
			Button buttonServoBackLeft2S01 = this.ButtonServoBackLeft_2_S0;
			size = new System.Drawing.Size(106, 23);
			buttonServoBackLeft2S01.Size = size;
			this.ButtonServoBackLeft_2_S0.TabIndex = 1;
			this.ButtonServoBackLeft_2_S0.Text = "Back Left 2 - S0";
			this.ButtonServoBackLeft_2_S0.UseVisualStyleBackColor = false;
			this.ButtonServoBackLeft_2_S0.Visible = false;
			this.ButtonServoBackLeft_1_S2.BackColor = Color.DarkGray;
			Button buttonServoBackLeft1S2 = this.ButtonServoBackLeft_1_S2;
			point = new Point(354, 132);
			buttonServoBackLeft1S2.Location = point;
			this.ButtonServoBackLeft_1_S2.Name = "ButtonServoBackLeft_1_S2";
			Button buttonServoBackLeft1S21 = this.ButtonServoBackLeft_1_S2;
			size = new System.Drawing.Size(106, 23);
			buttonServoBackLeft1S21.Size = size;
			this.ButtonServoBackLeft_1_S2.TabIndex = 0;
			this.ButtonServoBackLeft_1_S2.Text = "Back Left 1 - S2";
			this.ButtonServoBackLeft_1_S2.UseVisualStyleBackColor = false;
			this.ButtonServoBackLeft_1_S2.Visible = false;
			this.TabServoValues.Controls.Add(this.TextBoxPR1);
			this.TabServoValues.Controls.Add(this.TextBoxPR2);
			this.TabServoValues.Controls.Add(this.TextBoxPR3);
			this.TabServoValues.Controls.Add(this.TextBoxPR4);
			this.TabServoValues.Controls.Add(this.TextBoxBR4);
			this.TabServoValues.Controls.Add(this.TextBoxBR3);
			this.TabServoValues.Controls.Add(this.TextBoxBR2);
			this.TabServoValues.Controls.Add(this.TextBoxBR1);
			this.TabServoValues.Controls.Add(this.TextBoxPL1);
			this.TabServoValues.Controls.Add(this.TextBoxPL2);
			this.TabServoValues.Controls.Add(this.TextBoxPL3);
			this.TabServoValues.Controls.Add(this.TextBoxPL4);
			this.TabServoValues.Controls.Add(this.TextBoxBL4);
			this.TabServoValues.Controls.Add(this.TextBoxBL3);
			this.TabServoValues.Controls.Add(this.TextBoxBL2);
			this.TabServoValues.Controls.Add(this.TextBoxBL1);
			this.TabServoValues.Controls.Add(this.Label13);
			this.TabServoValues.Controls.Add(this.Label14);
			this.TabServoValues.Controls.Add(this.Label15);
			this.TabServoValues.Controls.Add(this.Label16);
			this.TabServoValues.Controls.Add(this.Label17);
			this.TabServoValues.Controls.Add(this.Label18);
			this.TabServoValues.Controls.Add(this.Label19);
			this.TabServoValues.Controls.Add(this.Label20);
			this.TabServoValues.Controls.Add(this.Label7);
			this.TabServoValues.Controls.Add(this.Label10);
			this.TabServoValues.Controls.Add(this.Label11);
			this.TabServoValues.Controls.Add(this.Label12);
			this.TabServoValues.Controls.Add(this.Label9);
			this.TabServoValues.Controls.Add(this.Label8);
			this.TabServoValues.Controls.Add(this.LabelBL2Value);
			this.TabServoValues.Controls.Add(this.LabelBL1Value);
			TabPage tabServoValues = this.TabServoValues;
			point = new Point(4, 25);
			tabServoValues.Location = point;
			this.TabServoValues.Name = "TabServoValues";
			TabPage tabServoValues1 = this.TabServoValues;
			size = new System.Drawing.Size(680, 569);
			tabServoValues1.Size = size;
			this.TabServoValues.TabIndex = 3;
			this.TabServoValues.Text = "Servo Values";
			this.TabServoValues.UseVisualStyleBackColor = true;
			this.TextBoxPR1.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBoxPR1 = this.TextBoxPR1;
			point = new Point(399, 427);
			textBoxPR1.Location = point;
			this.TextBoxPR1.Name = "TextBoxPR1";
			TextBox textBox = this.TextBoxPR1;
			size = new System.Drawing.Size(100, 30);
			textBox.Size = size;
			this.TextBoxPR1.TabIndex = 31;
			this.TextBoxPR1.Visible = false;
			this.TextBoxPR2.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBoxPR2 = this.TextBoxPR2;
			point = new Point(399, 391);
			textBoxPR2.Location = point;
			this.TextBoxPR2.Name = "TextBoxPR2";
			TextBox textBoxPR21 = this.TextBoxPR2;
			size = new System.Drawing.Size(100, 30);
			textBoxPR21.Size = size;
			this.TextBoxPR2.TabIndex = 30;
			this.TextBoxPR2.Visible = false;
			this.TextBoxPR3.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBoxPR3 = this.TextBoxPR3;
			point = new Point(399, 334);
			textBoxPR3.Location = point;
			this.TextBoxPR3.Name = "TextBoxPR3";
			TextBox textBoxPR31 = this.TextBoxPR3;
			size = new System.Drawing.Size(100, 30);
			textBoxPR31.Size = size;
			this.TextBoxPR3.TabIndex = 29;
			this.TextBoxPR3.Visible = false;
			this.TextBoxPR4.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBoxPR4 = this.TextBoxPR4;
			point = new Point(399, 298);
			textBoxPR4.Location = point;
			this.TextBoxPR4.Name = "TextBoxPR4";
			TextBox textBoxPR41 = this.TextBoxPR4;
			size = new System.Drawing.Size(100, 30);
			textBoxPR41.Size = size;
			this.TextBoxPR4.TabIndex = 28;
			this.TextBoxPR4.Visible = false;
			this.TextBoxBR4.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBoxBR4 = this.TextBoxBR4;
			point = new Point(399, 206);
			textBoxBR4.Location = point;
			this.TextBoxBR4.Name = "TextBoxBR4";
			TextBox textBoxBR41 = this.TextBoxBR4;
			size = new System.Drawing.Size(100, 30);
			textBoxBR41.Size = size;
			this.TextBoxBR4.TabIndex = 27;
			this.TextBoxBR4.Visible = false;
			this.TextBoxBR3.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBoxBR3 = this.TextBoxBR3;
			point = new Point(399, 170);
			textBoxBR3.Location = point;
			this.TextBoxBR3.Name = "TextBoxBR3";
			TextBox textBoxBR31 = this.TextBoxBR3;
			size = new System.Drawing.Size(100, 30);
			textBoxBR31.Size = size;
			this.TextBoxBR3.TabIndex = 26;
			this.TextBoxBR3.Visible = false;
			this.TextBoxBR2.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBoxBR2 = this.TextBoxBR2;
			point = new Point(399, 113);
			textBoxBR2.Location = point;
			this.TextBoxBR2.Name = "TextBoxBR2";
			TextBox textBoxBR21 = this.TextBoxBR2;
			size = new System.Drawing.Size(100, 30);
			textBoxBR21.Size = size;
			this.TextBoxBR2.TabIndex = 25;
			this.TextBoxBR2.Visible = false;
			this.TextBoxBR1.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBoxBR1 = this.TextBoxBR1;
			point = new Point(399, 77);
			textBoxBR1.Location = point;
			this.TextBoxBR1.Name = "TextBoxBR1";
			TextBox textBoxBR11 = this.TextBoxBR1;
			size = new System.Drawing.Size(100, 30);
			textBoxBR11.Size = size;
			this.TextBoxBR1.TabIndex = 24;
			this.TextBoxBR1.Visible = false;
			this.TextBoxPL1.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBoxPL1 = this.TextBoxPL1;
			point = new Point(164, 427);
			textBoxPL1.Location = point;
			this.TextBoxPL1.Name = "TextBoxPL1";
			TextBox textBoxPL11 = this.TextBoxPL1;
			size = new System.Drawing.Size(100, 30);
			textBoxPL11.Size = size;
			this.TextBoxPL1.TabIndex = 23;
			this.TextBoxPL1.Visible = false;
			this.TextBoxPL2.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBoxPL2 = this.TextBoxPL2;
			point = new Point(164, 391);
			textBoxPL2.Location = point;
			this.TextBoxPL2.Name = "TextBoxPL2";
			TextBox textBoxPL21 = this.TextBoxPL2;
			size = new System.Drawing.Size(100, 30);
			textBoxPL21.Size = size;
			this.TextBoxPL2.TabIndex = 22;
			this.TextBoxPL2.Visible = false;
			this.TextBoxPL3.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBoxPL3 = this.TextBoxPL3;
			point = new Point(164, 334);
			textBoxPL3.Location = point;
			this.TextBoxPL3.Name = "TextBoxPL3";
			TextBox textBoxPL31 = this.TextBoxPL3;
			size = new System.Drawing.Size(100, 30);
			textBoxPL31.Size = size;
			this.TextBoxPL3.TabIndex = 21;
			this.TextBoxPL3.Visible = false;
			this.TextBoxPL4.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBoxPL4 = this.TextBoxPL4;
			point = new Point(164, 298);
			textBoxPL4.Location = point;
			this.TextBoxPL4.Name = "TextBoxPL4";
			TextBox textBoxPL41 = this.TextBoxPL4;
			size = new System.Drawing.Size(100, 30);
			textBoxPL41.Size = size;
			this.TextBoxPL4.TabIndex = 20;
			this.TextBoxPL4.Visible = false;
			this.TextBoxBL4.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBoxBL4 = this.TextBoxBL4;
			point = new Point(164, 206);
			textBoxBL4.Location = point;
			this.TextBoxBL4.Name = "TextBoxBL4";
			TextBox textBoxBL41 = this.TextBoxBL4;
			size = new System.Drawing.Size(100, 30);
			textBoxBL41.Size = size;
			this.TextBoxBL4.TabIndex = 19;
			this.TextBoxBL4.Visible = false;
			this.TextBoxBL3.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBoxBL3 = this.TextBoxBL3;
			point = new Point(164, 170);
			textBoxBL3.Location = point;
			this.TextBoxBL3.Name = "TextBoxBL3";
			TextBox textBoxBL31 = this.TextBoxBL3;
			size = new System.Drawing.Size(100, 30);
			textBoxBL31.Size = size;
			this.TextBoxBL3.TabIndex = 18;
			this.TextBoxBL3.Visible = false;
			this.TextBoxBL2.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBoxBL2 = this.TextBoxBL2;
			point = new Point(164, 113);
			textBoxBL2.Location = point;
			this.TextBoxBL2.Name = "TextBoxBL2";
			TextBox textBoxBL21 = this.TextBoxBL2;
			size = new System.Drawing.Size(100, 30);
			textBoxBL21.Size = size;
			this.TextBoxBL2.TabIndex = 17;
			this.TextBoxBL2.Visible = false;
			this.TextBoxBL1.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox textBoxBL1 = this.TextBoxBL1;
			point = new Point(164, 77);
			textBoxBL1.Location = point;
			this.TextBoxBL1.Name = "TextBoxBL1";
			TextBox textBoxBL11 = this.TextBoxBL1;
			size = new System.Drawing.Size(100, 30);
			textBoxBL11.Size = size;
			this.TextBoxBL1.TabIndex = 16;
			this.TextBoxBL1.Visible = false;
			this.Label13.AutoSize = true;
			this.Label13.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label13 = this.Label13;
			point = new Point(345, 301);
			label13.Location = point;
			this.Label13.Name = "Label13";
			Label label131 = this.Label13;
			size = new System.Drawing.Size(48, 24);
			label131.Size = size;
			this.Label13.TabIndex = 15;
			this.Label13.Text = "PR4";
			this.Label13.Visible = false;
			this.Label14.AutoSize = true;
			this.Label14.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label14 = this.Label14;
			point = new Point(345, 337);
			label14.Location = point;
			this.Label14.Name = "Label14";
			Label label141 = this.Label14;
			size = new System.Drawing.Size(48, 24);
			label141.Size = size;
			this.Label14.TabIndex = 14;
			this.Label14.Text = "PR3";
			this.Label14.Visible = false;
			this.Label15.AutoSize = true;
			this.Label15.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label15 = this.Label15;
			point = new Point(345, 394);
			label15.Location = point;
			this.Label15.Name = "Label15";
			Label label151 = this.Label15;
			size = new System.Drawing.Size(48, 24);
			label151.Size = size;
			this.Label15.TabIndex = 13;
			this.Label15.Text = "PR2";
			this.Label15.Visible = false;
			this.Label16.AutoSize = true;
			this.Label16.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label16 = this.Label16;
			point = new Point(345, 430);
			label16.Location = point;
			this.Label16.Name = "Label16";
			Label label161 = this.Label16;
			size = new System.Drawing.Size(48, 24);
			label161.Size = size;
			this.Label16.TabIndex = 12;
			this.Label16.Text = "PR1";
			this.Label16.Visible = false;
			this.Label17.AutoSize = true;
			this.Label17.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label17 = this.Label17;
			point = new Point(112, 301);
			label17.Location = point;
			this.Label17.Name = "Label17";
			Label label171 = this.Label17;
			size = new System.Drawing.Size(46, 24);
			label171.Size = size;
			this.Label17.TabIndex = 11;
			this.Label17.Text = "PL4";
			this.Label17.Visible = false;
			this.Label18.AutoSize = true;
			this.Label18.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label18 = this.Label18;
			point = new Point(111, 337);
			label18.Location = point;
			this.Label18.Name = "Label18";
			Label label181 = this.Label18;
			size = new System.Drawing.Size(46, 24);
			label181.Size = size;
			this.Label18.TabIndex = 10;
			this.Label18.Text = "PL3";
			this.Label18.Visible = false;
			this.Label19.AutoSize = true;
			this.Label19.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label19 = this.Label19;
			point = new Point(112, 394);
			label19.Location = point;
			this.Label19.Name = "Label19";
			Label label191 = this.Label19;
			size = new System.Drawing.Size(46, 24);
			label191.Size = size;
			this.Label19.TabIndex = 9;
			this.Label19.Text = "PL2";
			this.Label19.Visible = false;
			this.Label20.AutoSize = true;
			this.Label20.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label20 = this.Label20;
			point = new Point(111, 430);
			label20.Location = point;
			this.Label20.Name = "Label20";
			Label label201 = this.Label20;
			size = new System.Drawing.Size(46, 24);
			label201.Size = size;
			this.Label20.TabIndex = 8;
			this.Label20.Text = "PL1";
			this.Label20.Visible = false;
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label7 = this.Label7;
			point = new Point(344, 209);
			label7.Location = point;
			this.Label7.Name = "Label7";
			Label label71 = this.Label7;
			size = new System.Drawing.Size(49, 24);
			label71.Size = size;
			this.Label7.TabIndex = 7;
			this.Label7.Text = "BR4";
			this.Label7.Visible = false;
			this.Label10.AutoSize = true;
			this.Label10.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label10 = this.Label10;
			point = new Point(344, 173);
			label10.Location = point;
			this.Label10.Name = "Label10";
			Label label101 = this.Label10;
			size = new System.Drawing.Size(49, 24);
			label101.Size = size;
			this.Label10.TabIndex = 6;
			this.Label10.Text = "BR3";
			this.Label10.Visible = false;
			this.Label11.AutoSize = true;
			this.Label11.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label11 = this.Label11;
			point = new Point(344, 116);
			label11.Location = point;
			this.Label11.Name = "Label11";
			Label label111 = this.Label11;
			size = new System.Drawing.Size(49, 24);
			label111.Size = size;
			this.Label11.TabIndex = 5;
			this.Label11.Text = "BR2";
			this.Label11.Visible = false;
			this.Label12.AutoSize = true;
			this.Label12.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label12 = this.Label12;
			point = new Point(345, 80);
			label12.Location = point;
			this.Label12.Name = "Label12";
			Label label121 = this.Label12;
			size = new System.Drawing.Size(49, 24);
			label121.Size = size;
			this.Label12.TabIndex = 4;
			this.Label12.Text = "BR1";
			this.Label12.Visible = false;
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label9 = this.Label9;
			point = new Point(111, 206);
			label9.Location = point;
			this.Label9.Name = "Label9";
			Label label91 = this.Label9;
			size = new System.Drawing.Size(47, 24);
			label91.Size = size;
			this.Label9.TabIndex = 3;
			this.Label9.Text = "BL4";
			this.Label9.Visible = false;
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label8 = this.Label8;
			point = new Point(111, 173);
			label8.Location = point;
			this.Label8.Name = "Label8";
			Label label81 = this.Label8;
			size = new System.Drawing.Size(47, 24);
			label81.Size = size;
			this.Label8.TabIndex = 2;
			this.Label8.Text = "BL3";
			this.Label8.Visible = false;
			this.LabelBL2Value.AutoSize = true;
			this.LabelBL2Value.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label labelBL2Value = this.LabelBL2Value;
			point = new Point(111, 116);
			labelBL2Value.Location = point;
			this.LabelBL2Value.Name = "LabelBL2Value";
			Label labelBL2Value1 = this.LabelBL2Value;
			size = new System.Drawing.Size(47, 24);
			labelBL2Value1.Size = size;
			this.LabelBL2Value.TabIndex = 1;
			this.LabelBL2Value.Text = "BL2";
			this.LabelBL2Value.Visible = false;
			this.LabelBL1Value.AutoSize = true;
			this.LabelBL1Value.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label labelBL1Value = this.LabelBL1Value;
			point = new Point(111, 80);
			labelBL1Value.Location = point;
			this.LabelBL1Value.Name = "LabelBL1Value";
			Label labelBL1Value1 = this.LabelBL1Value;
			size = new System.Drawing.Size(47, 24);
			labelBL1Value1.Size = size;
			this.LabelBL1Value.TabIndex = 0;
			this.LabelBL1Value.Text = "BL1";
			this.LabelBL1Value.Visible = false;
			this.TabPage1.Controls.Add(this.Label6);
			this.TabPage1.Controls.Add(this.Button1);
			this.TabPage1.Controls.Add(this._Scroll_10);
			this.TabPage1.Controls.Add(this._Scroll_0);
			this.TabPage1.Controls.Add(this.Label1);
			this.TabPage1.Controls.Add(this._Scroll_1);
			this.TabPage1.Controls.Add(this._Scroll_15);
			this.TabPage1.Controls.Add(this._Scroll_2);
			this.TabPage1.Controls.Add(this._Scroll_14);
			this.TabPage1.Controls.Add(this._Scroll_3);
			this.TabPage1.Controls.Add(this._Scroll_13);
			this.TabPage1.Controls.Add(this._Scroll_4);
			this.TabPage1.Controls.Add(this._Scroll_12);
			this.TabPage1.Controls.Add(this._Scroll_5);
			this.TabPage1.Controls.Add(this._Scroll_11);
			this.TabPage1.Controls.Add(this._Scroll_6);
			this.TabPage1.Controls.Add(this._Scroll_9);
			this.TabPage1.Controls.Add(this._Scroll_7);
			this.TabPage1.Controls.Add(this._Scroll_8);
			TabPage tabPage11 = this.TabPage1;
			point = new Point(4, 25);
			tabPage11.Location = point;
			this.TabPage1.Name = "TabPage1";
			TabPage tabPage12 = this.TabPage1;
			padding = new System.Windows.Forms.Padding(3);
			tabPage12.Padding = padding;
			TabPage tabPage2 = this.TabPage1;
			size = new System.Drawing.Size(680, 569);
			tabPage2.Size = size;
			this.TabPage1.TabIndex = 2;
			this.TabPage1.Text = "TabPage1";
			this.TabPage1.UseVisualStyleBackColor = true;
			this.Label6.AutoSize = true;
			Label label6 = this.Label6;
			point = new Point(70, 101);
			label6.Location = point;
			this.Label6.Name = "Label6";
			Label label61 = this.Label6;
			size = new System.Drawing.Size(51, 16);
			label61.Size = size;
			this.Label6.TabIndex = 35;
			this.Label6.Text = "Label6";
			this.Label6.Visible = false;
			Button button1 = this.Button1;
			point = new Point(52, 59);
			button1.Location = point;
			this.Button1.Name = "Button1";
			Button button11 = this.Button1;
			size = new System.Drawing.Size(75, 23);
			button11.Size = size;
			this.Button1.TabIndex = 34;
			this.Button1.Text = "Get BD #";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button1.Visible = false;
			this._Scroll_10.Cursor = Cursors.Default;
			this._Scroll_10.LargeChange = 1;
			VScrollBar _Scroll10 = this._Scroll_10;
			point = new Point(372, 147);
			_Scroll10.Location = point;
			this._Scroll_10.Maximum = 16383;
			this._Scroll_10.Name = "_Scroll_10";
			VScrollBar _Scroll101 = this._Scroll_10;
			size = new System.Drawing.Size(17, 253);
			_Scroll101.Size = size;
			this._Scroll_10.TabIndex = 22;
			this._Scroll_10.TabStop = true;
			this._Scroll_10.Value = 8096;
			this._Scroll_10.Visible = false;
			this._Scroll_0.Cursor = Cursors.Default;
			this._Scroll_0.LargeChange = 1;
			VScrollBar _Scroll0 = this._Scroll_0;
			point = new Point(204, 147);
			_Scroll0.Location = point;
			this._Scroll_0.Maximum = 16383;
			this._Scroll_0.Name = "_Scroll_0";
			VScrollBar _Scroll01 = this._Scroll_0;
			size = new System.Drawing.Size(17, 253);
			_Scroll01.Size = size;
			this._Scroll_0.TabIndex = 32;
			this._Scroll_0.TabStop = true;
			this._Scroll_0.Value = 8096;
			this._Scroll_0.Visible = false;
			this.Label1.BackColor = SystemColors.Control;
			this.Label1.Cursor = Cursors.Default;
			this.Label1.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label1.ForeColor = SystemColors.ControlText;
			Label label110 = this.Label1;
			point = new Point(204, 127);
			label110.Location = point;
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label label112 = this.Label1;
			size = new System.Drawing.Size(273, 17);
			label112.Size = size;
			this.Label1.TabIndex = 33;
			this.Label1.Text = " 0  1   2   3    4   5    6   7        8   9  10  11 12 13 14 15  ";
			this.Label1.Visible = false;
			this._Scroll_1.Cursor = Cursors.Default;
			this._Scroll_1.LargeChange = 1;
			VScrollBar _Scroll1 = this._Scroll_1;
			point = new Point(220, 147);
			_Scroll1.Location = point;
			this._Scroll_1.Maximum = 16383;
			this._Scroll_1.Name = "_Scroll_1";
			VScrollBar _Scroll11 = this._Scroll_1;
			size = new System.Drawing.Size(17, 253);
			_Scroll11.Size = size;
			this._Scroll_1.TabIndex = 31;
			this._Scroll_1.TabStop = true;
			this._Scroll_1.Value = 8096;
			this._Scroll_1.Visible = false;
			this._Scroll_15.Cursor = Cursors.Default;
			this._Scroll_15.LargeChange = 1;
			VScrollBar _Scroll15 = this._Scroll_15;
			point = new Point(452, 147);
			_Scroll15.Location = point;
			this._Scroll_15.Maximum = 16383;
			this._Scroll_15.Name = "_Scroll_15";
			VScrollBar _Scroll151 = this._Scroll_15;
			size = new System.Drawing.Size(17, 253);
			_Scroll151.Size = size;
			this._Scroll_15.TabIndex = 17;
			this._Scroll_15.TabStop = true;
			this._Scroll_15.Value = 8096;
			this._Scroll_15.Visible = false;
			this._Scroll_2.Cursor = Cursors.Default;
			this._Scroll_2.LargeChange = 1;
			VScrollBar _Scroll2 = this._Scroll_2;
			point = new Point(236, 147);
			_Scroll2.Location = point;
			this._Scroll_2.Maximum = 16383;
			this._Scroll_2.Name = "_Scroll_2";
			VScrollBar _Scroll21 = this._Scroll_2;
			size = new System.Drawing.Size(17, 253);
			_Scroll21.Size = size;
			this._Scroll_2.TabIndex = 30;
			this._Scroll_2.TabStop = true;
			this._Scroll_2.Value = 8096;
			this._Scroll_2.Visible = false;
			this._Scroll_14.Cursor = Cursors.Default;
			this._Scroll_14.LargeChange = 1;
			VScrollBar _Scroll14 = this._Scroll_14;
			point = new Point(436, 147);
			_Scroll14.Location = point;
			this._Scroll_14.Maximum = 16383;
			this._Scroll_14.Name = "_Scroll_14";
			VScrollBar _Scroll141 = this._Scroll_14;
			size = new System.Drawing.Size(17, 253);
			_Scroll141.Size = size;
			this._Scroll_14.TabIndex = 18;
			this._Scroll_14.TabStop = true;
			this._Scroll_14.Value = 8096;
			this._Scroll_14.Visible = false;
			this._Scroll_3.Cursor = Cursors.Default;
			this._Scroll_3.LargeChange = 1;
			VScrollBar _Scroll3 = this._Scroll_3;
			point = new Point(252, 147);
			_Scroll3.Location = point;
			this._Scroll_3.Maximum = 16383;
			this._Scroll_3.Name = "_Scroll_3";
			VScrollBar _Scroll31 = this._Scroll_3;
			size = new System.Drawing.Size(17, 253);
			_Scroll31.Size = size;
			this._Scroll_3.TabIndex = 29;
			this._Scroll_3.TabStop = true;
			this._Scroll_3.Value = 8096;
			this._Scroll_3.Visible = false;
			this._Scroll_13.Cursor = Cursors.Default;
			this._Scroll_13.LargeChange = 1;
			VScrollBar _Scroll13 = this._Scroll_13;
			point = new Point(420, 147);
			_Scroll13.Location = point;
			this._Scroll_13.Maximum = 16383;
			this._Scroll_13.Name = "_Scroll_13";
			VScrollBar _Scroll131 = this._Scroll_13;
			size = new System.Drawing.Size(17, 253);
			_Scroll131.Size = size;
			this._Scroll_13.TabIndex = 19;
			this._Scroll_13.TabStop = true;
			this._Scroll_13.Value = 8096;
			this._Scroll_13.Visible = false;
			this._Scroll_4.Cursor = Cursors.Default;
			this._Scroll_4.LargeChange = 1;
			VScrollBar _Scroll4 = this._Scroll_4;
			point = new Point(268, 147);
			_Scroll4.Location = point;
			this._Scroll_4.Maximum = 16383;
			this._Scroll_4.Name = "_Scroll_4";
			VScrollBar _Scroll41 = this._Scroll_4;
			size = new System.Drawing.Size(17, 253);
			_Scroll41.Size = size;
			this._Scroll_4.TabIndex = 28;
			this._Scroll_4.TabStop = true;
			this._Scroll_4.Value = 8096;
			this._Scroll_4.Visible = false;
			this._Scroll_12.Cursor = Cursors.Default;
			this._Scroll_12.LargeChange = 1;
			VScrollBar _Scroll12 = this._Scroll_12;
			point = new Point(404, 147);
			_Scroll12.Location = point;
			this._Scroll_12.Maximum = 16383;
			this._Scroll_12.Name = "_Scroll_12";
			VScrollBar _Scroll121 = this._Scroll_12;
			size = new System.Drawing.Size(17, 253);
			_Scroll121.Size = size;
			this._Scroll_12.TabIndex = 20;
			this._Scroll_12.TabStop = true;
			this._Scroll_12.Value = 8096;
			this._Scroll_12.Visible = false;
			this._Scroll_5.Cursor = Cursors.Default;
			this._Scroll_5.LargeChange = 1;
			VScrollBar _Scroll5 = this._Scroll_5;
			point = new Point(284, 147);
			_Scroll5.Location = point;
			this._Scroll_5.Maximum = 16383;
			this._Scroll_5.Name = "_Scroll_5";
			VScrollBar _Scroll51 = this._Scroll_5;
			size = new System.Drawing.Size(17, 253);
			_Scroll51.Size = size;
			this._Scroll_5.TabIndex = 27;
			this._Scroll_5.TabStop = true;
			this._Scroll_5.Value = 8096;
			this._Scroll_5.Visible = false;
			this._Scroll_11.Cursor = Cursors.Default;
			this._Scroll_11.LargeChange = 1;
			VScrollBar _Scroll111 = this._Scroll_11;
			point = new Point(388, 147);
			_Scroll111.Location = point;
			this._Scroll_11.Maximum = 16383;
			this._Scroll_11.Name = "_Scroll_11";
			VScrollBar vScrollBar1 = this._Scroll_11;
			size = new System.Drawing.Size(17, 253);
			vScrollBar1.Size = size;
			this._Scroll_11.TabIndex = 21;
			this._Scroll_11.TabStop = true;
			this._Scroll_11.Value = 8096;
			this._Scroll_11.Visible = false;
			this._Scroll_6.Cursor = Cursors.Default;
			this._Scroll_6.LargeChange = 1;
			VScrollBar _Scroll6 = this._Scroll_6;
			point = new Point(300, 147);
			_Scroll6.Location = point;
			this._Scroll_6.Maximum = 16383;
			this._Scroll_6.Name = "_Scroll_6";
			VScrollBar _Scroll61 = this._Scroll_6;
			size = new System.Drawing.Size(17, 253);
			_Scroll61.Size = size;
			this._Scroll_6.TabIndex = 26;
			this._Scroll_6.TabStop = true;
			this._Scroll_6.Value = 8096;
			this._Scroll_6.Visible = false;
			this._Scroll_9.Cursor = Cursors.Default;
			this._Scroll_9.LargeChange = 1;
			VScrollBar _Scroll9 = this._Scroll_9;
			point = new Point(356, 147);
			_Scroll9.Location = point;
			this._Scroll_9.Maximum = 16383;
			this._Scroll_9.Name = "_Scroll_9";
			VScrollBar _Scroll91 = this._Scroll_9;
			size = new System.Drawing.Size(17, 253);
			_Scroll91.Size = size;
			this._Scroll_9.TabIndex = 23;
			this._Scroll_9.TabStop = true;
			this._Scroll_9.Value = 8096;
			this._Scroll_9.Visible = false;
			this._Scroll_7.Cursor = Cursors.Default;
			this._Scroll_7.LargeChange = 1;
			VScrollBar _Scroll7 = this._Scroll_7;
			point = new Point(316, 147);
			_Scroll7.Location = point;
			this._Scroll_7.Maximum = 16383;
			this._Scroll_7.Name = "_Scroll_7";
			VScrollBar _Scroll71 = this._Scroll_7;
			size = new System.Drawing.Size(17, 253);
			_Scroll71.Size = size;
			this._Scroll_7.TabIndex = 25;
			this._Scroll_7.TabStop = true;
			this._Scroll_7.Value = 8096;
			this._Scroll_7.Visible = false;
			this._Scroll_8.Cursor = Cursors.Default;
			this._Scroll_8.LargeChange = 1;
			VScrollBar _Scroll8 = this._Scroll_8;
			point = new Point(340, 147);
			_Scroll8.Location = point;
			this._Scroll_8.Maximum = 16383;
			this._Scroll_8.Name = "_Scroll_8";
			VScrollBar _Scroll81 = this._Scroll_8;
			size = new System.Drawing.Size(17, 253);
			_Scroll81.Size = size;
			this._Scroll_8.TabIndex = 24;
			this._Scroll_8.TabStop = true;
			this._Scroll_8.Value = 8096;
			this._Scroll_8.Visible = false;
			this.AutoScaleDimensions = new SizeF(7f, 16f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			size = new System.Drawing.Size(712, 623);
			this.ClientSize = size;
			this.Controls.Add(this.TabControl1);
			this.Cursor = Cursors.Default;
			this.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			point = new Point(3, 29);
			this.Location = point;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.Text = "GS-4 Calibration Utility";
			((ISupportInitialize)this.Scroll_Renamed).EndInit();
			this.TabControl1.ResumeLayout(false);
			this.TabCalRev2.ResumeLayout(false);
			this.TabCalRev2.PerformLayout();
			((ISupportInitialize)this.NumericUpDownMinRange).EndInit();
			((ISupportInitialize)this.NumericUpDownMaxRange).EndInit();
			((ISupportInitialize)this.NumericUpDownInitialPosition).EndInit();
			((ISupportInitialize)this.NumericUpDownFine).EndInit();
			((ISupportInitialize)this.NumericUpDownCoarse).EndInit();
			this.GroupBoxPanRight.ResumeLayout(false);
			this.GroupBoxPanLeft.ResumeLayout(false);
			this.GroupBoxBackRight.ResumeLayout(false);
			this.GroupBoxBackLeft.ResumeLayout(false);
			((ISupportInitialize)this.NumericUpDownCalRev2ComPort).EndInit();
			this.TabPanelMove.ResumeLayout(false);
			this.TabPanelMove.PerformLayout();
			this.TabCalibration.ResumeLayout(false);
			((ISupportInitialize)this.NumericUpDownComPort).EndInit();
			this.TabServoValues.ResumeLayout(false);
			this.TabServoValues.PerformLayout();
			this.TabPage1.ResumeLayout(false);
			this.TabPage1.PerformLayout();
			this.ResumeLayout(false);
		}

		private void LabelBL1Value_Click(object sender, EventArgs e)
		{
		}

		[STAThread]
		//public static void Main()
		//{
		//	Application.Run();
		//}

		private void MoveAllMax()
		{
			Module1.QuickMoveRaw(this.sccom, this.scboard, 0, 15753);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 1, 15753);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 2, 15753);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 3, 15753);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 4, 15753);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 5, 15753);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 6, 15753);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 7, 15753);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 8, 15753);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 9, 15753);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 10, 15753);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 11, 15753);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 12, 15753);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 13, 15753);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 14, 15753);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 15, 15753);
		}

		private void MoveAllMin()
		{
			Module1.QuickMoveRaw(this.sccom, this.scboard, 0, 500);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 1, 500);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 2, 500);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 3, 500);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 4, 500);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 5, 500);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 6, 500);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 7, 500);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 8, 500);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 9, 500);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 10, 500);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 11, 500);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 12, 500);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 13, 500);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 14, 500);
			Module1.QuickMoveRaw(this.sccom, this.scboard, 15, 500);
		}

		public void MoveServos(ref short Index)
		{
			Module1.QuickMoveRaw(this.sccom, this.scboard, Index, this.Scroll_Renamed[Index].Value);
		}

		private void NumericUpDownComPort_ValueChanged(object sender, EventArgs e)
		{
			this.sccom = Convert.ToInt16(this.NumericUpDownComPort.Value);
		}

		private void Scroll_Change(ref short Index, int newScrollValue)
		{
			this.MoveServos(ref Index);
		}

		private void Scroll_Renamed_Scroll(object eventSender, ScrollEventArgs eventArgs)
		{
			short index = this.Scroll_Renamed.GetIndex((VScrollBar)eventSender);
			switch (eventArgs.Type)
			{
				case ScrollEventType.ThumbTrack:
				{
					this.Scroll_Scroll_Renamed(ref index, eventArgs.NewValue);
					return;
				}
				case ScrollEventType.First:
				case ScrollEventType.Last:
				{
					return;
				}
				case ScrollEventType.EndScroll:
				{
					this.Scroll_Change(ref index, eventArgs.NewValue);
					return;
				}
				default:
				{
					return;
				}
			}
		}

		private void Scroll_Scroll_Renamed(ref short Index, int newScrollValue)
		{
			this.MoveServos(ref Index);
		}

		private void ServoButtonColorRed()
		{
			this.ButtonServoBackLeft_1_S2.BackColor = Color.Red;
			this.ButtonServoBackLeft_2_S0.BackColor = Color.Red;
			this.ButtonServoBackLeft_3_S10.BackColor = Color.Red;
			this.ButtonServoBackLeft_4_S8.BackColor = Color.Red;
			this.ButtonServoBackRight_1_S1.BackColor = Color.Red;
			this.ButtonServoBackRight_2_S3.BackColor = Color.Red;
			this.ButtonServoBackRight_3_S9.BackColor = Color.Red;
			this.ButtonServoBackRight_4_S11.BackColor = Color.Red;
			this.ButtonServoPanLeft_1_S4.BackColor = Color.Red;
			this.ButtonServoPanLeft_2_S6.BackColor = Color.Red;
			this.ButtonServoPanLeft_3_S12.BackColor = Color.Red;
			this.ButtonServoPanLeft_4_S14.BackColor = Color.Red;
			this.ButtonServoPanRight_1_S7.BackColor = Color.Red;
			this.ButtonServoPanRight_2_S5.BackColor = Color.Red;
			this.ButtonServoPanRight_3_S15.BackColor = Color.Red;
			this.ButtonServoPanRight_4_S13.BackColor = Color.Red;
		}

		public void StartDisableServos()
		{
			Thread.Sleep(1000);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 0);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 1);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 2);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 3);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 4);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 5);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 6);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 7);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 8);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 9);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 10);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 11);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 12);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 13);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 14);
			Module1.ServoDisable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 15);
			Thread.Sleep(1000);
		}

		public void StartEnableServos()
		{
			Thread.Sleep(1000);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 0);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 0);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 1);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 2);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 3);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 4);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 5);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 6);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 7);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 8);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 9);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 10);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 11);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 12);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 13);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 14);
			Module1.ServoEnable(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 15);
		}

		public void StartMoveServos()
		{
			Thread.Sleep(1000);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 0, 5000);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 1, 5000);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 2, 5000);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 3, 5000);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 4, 5000);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 5, 5000);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 6, 5000);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 7, 5000);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 8, 5000);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 9, 5000);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 10, 5000);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 11, 5000);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 12, 5000);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 13, 5000);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 14, 5000);
			Module1.QuickMoveRaw(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 15, 5000);
		}

		private void TurnCurrentServoButtonGreen()
		{
			if (Operators.CompareString(this.CurrentServoButton, "ButtonServoBackLeft_1_S2", false) == 0)
			{
				this.ButtonServoBackLeft_1_S2.BackColor = Color.GreenYellow;
			}
			if (Operators.CompareString(this.CurrentServoButton, "ButtonServoBackLeft_2_S0", false) == 0)
			{
				this.ButtonServoBackLeft_2_S0.BackColor = Color.GreenYellow;
			}
			if (Operators.CompareString(this.CurrentServoButton, "ButtonServoBackLeft_3_S10", false) == 0)
			{
				this.ButtonServoBackLeft_3_S10.BackColor = Color.GreenYellow;
			}
			if (Operators.CompareString(this.CurrentServoButton, "ButtonServoBackLeft_4_S8", false) == 0)
			{
				this.ButtonServoBackLeft_4_S8.BackColor = Color.GreenYellow;
			}
			if (Operators.CompareString(this.CurrentServoButton, "ButtonServoBackRight_1_S1", false) == 0)
			{
				this.ButtonServoBackRight_1_S1.BackColor = Color.GreenYellow;
			}
			if (Operators.CompareString(this.CurrentServoButton, "ButtonServoBackRight_2_S3", false) == 0)
			{
				this.ButtonServoBackRight_2_S3.BackColor = Color.GreenYellow;
			}
			if (Operators.CompareString(this.CurrentServoButton, "ButtonServoBackRight_3_S9", false) == 0)
			{
				this.ButtonServoBackRight_3_S9.BackColor = Color.GreenYellow;
			}
			if (Operators.CompareString(this.CurrentServoButton, "ButtonServoBackRight_4_S11", false) == 0)
			{
				this.ButtonServoBackRight_4_S11.BackColor = Color.GreenYellow;
			}
			if (Operators.CompareString(this.CurrentServoButton, "ButtonServoPanLeft_1_S4", false) == 0)
			{
				this.ButtonServoPanLeft_1_S4.BackColor = Color.GreenYellow;
			}
			if (Operators.CompareString(this.CurrentServoButton, "ButtonServoPanLeft_2_S6", false) == 0)
			{
				this.ButtonServoPanLeft_2_S6.BackColor = Color.GreenYellow;
			}
			if (Operators.CompareString(this.CurrentServoButton, "ButtonServoPanLeft_3_S12", false) == 0)
			{
				this.ButtonServoPanLeft_3_S12.BackColor = Color.GreenYellow;
			}
			if (Operators.CompareString(this.CurrentServoButton, "ButtonServoPanLeft_4_S14", false) == 0)
			{
				this.ButtonServoPanLeft_4_S14.BackColor = Color.GreenYellow;
			}
			if (Operators.CompareString(this.CurrentServoButton, "ButtonServoPanRight_1_S7", false) == 0)
			{
				this.ButtonServoPanRight_1_S7.BackColor = Color.GreenYellow;
			}
			if (Operators.CompareString(this.CurrentServoButton, "ButtonServoPanRight_2_S5", false) == 0)
			{
				this.ButtonServoPanRight_2_S5.BackColor = Color.GreenYellow;
			}
			if (Operators.CompareString(this.CurrentServoButton, "ButtonServoPanRight_3_S15", false) == 0)
			{
				this.ButtonServoPanRight_3_S15.BackColor = Color.GreenYellow;
			}
			if (Operators.CompareString(this.CurrentServoButton, "ButtonServoPanRight_4_S13", false) == 0)
			{
				this.ButtonServoPanRight_4_S13.BackColor = Color.GreenYellow;
			}
		}

		private void VScrollBarBackLeftPanel_Scroll(object sender, ScrollEventArgs e)
		{
			Module1.QuickMovePercent(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 2, (float)this.VScrollBarBackLeftPanel.Value);
			Module1.QuickMovePercent(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 0, (float)this.VScrollBarBackLeftPanel.Value);
			Module1.QuickMovePercent(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 10, (float)this.VScrollBarBackLeftPanel.Value);
			Module1.QuickMovePercent(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 8, (float)this.VScrollBarBackLeftPanel.Value);
			this.LabelBackPanelValueLeft.Text = Conversions.ToString(this.VScrollBarBackLeftPanel.Value);
		}

		private void VScrollBarBackRightPanel_Scroll(object sender, ScrollEventArgs e)
		{
			Module1.CompactMovePercent(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 1, (float)this.VScrollBarBackRightPanel.Value, 100f);
			Module1.CompactMovePercent(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 3, (float)this.VScrollBarBackRightPanel.Value, 100f);
			Module1.CompactMovePercent(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 9, (float)this.VScrollBarBackRightPanel.Value, 100f);
			Module1.CompactMovePercent(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 11, (float)this.VScrollBarBackRightPanel.Value, 100f);
			this.LabelBackPanelValueRight.Text = Conversions.ToString(this.VScrollBarBackRightPanel.Value);
		}

		private void VScrollBarCalibration_Scroll(object sender, ScrollEventArgs e)
		{
			Module1.QuickMoveRaw(this.sccom, this.scboard, this.CurrentServo, this.VScrollBarCalibration.Value);
		}

		private void VScrollBarPanLeftPanel_Scroll(object sender, ScrollEventArgs e)
		{
			Module1.CompactMovePercent(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 4, (float)this.VScrollBarPanLeftPanel.Value, 100f);
			Module1.CompactMovePercent(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 6, (float)this.VScrollBarPanLeftPanel.Value, 100f);
			Module1.CompactMovePercent(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 12, (float)this.VScrollBarPanLeftPanel.Value, 100f);
			Module1.CompactMovePercent(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 14, (float)this.VScrollBarPanLeftPanel.Value, 100f);
			this.LabelPanPanelValueLeft.Text = Conversions.ToString(this.VScrollBarPanLeftPanel.Value);
		}

		private void VScrollBarPanRightPanel_Scroll(object sender, ScrollEventArgs e)
		{
			Module1.CompactMovePercent(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 7, (float)this.VScrollBarPanRightPanel.Value, 100f);
			Module1.CompactMovePercent(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 5, (float)this.VScrollBarPanRightPanel.Value, 100f);
			Module1.CompactMovePercent(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 15, (float)this.VScrollBarPanRightPanel.Value, 100f);
			Module1.CompactMovePercent(Convert.ToInt32(this.NumericUpDownCalRev2ComPort.Value), this.scboard, 13, (float)this.VScrollBarPanRightPanel.Value, 100f);
			this.LabelPanPanelValueRight.Text = Conversions.ToString(this.VScrollBarPanRightPanel.Value);
		}
	}
}