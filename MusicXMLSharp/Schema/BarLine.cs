/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class BarLine {
    
    private BarStyleColor barstyleField;
    
    private FormattedText footnoteField;
    
    private Level levelField;
    
    private WavyLine _wavyLineField;
    
    private EmptyPrintStyleAlign segnoField;
    
    private EmptyPrintStyleAlign codaField;
    
    private Fermata[] fermataField;
    
    private Ending endingField;
    
    private Repeat repeatField;
    
    private RightLeftMiddle locationField;
    
    private string segno1Field;
    
    private string coda1Field;
    
    private decimal divisionsField;
    
    private bool divisionsFieldSpecified;
    
    public BarLine() {
        this.locationField = RightLeftMiddle.right;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bar-style")]
    public BarStyleColor barstyle {
        get {
            return this.barstyleField;
        }
        set {
            this.barstyleField = value;
        }
    }
    
    /// <remarks/>
    public FormattedText footnote {
        get {
            return this.footnoteField;
        }
        set {
            this.footnoteField = value;
        }
    }
    
    /// <remarks/>
    public Level level {
        get {
            return this.levelField;
        }
        set {
            this.levelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("wavy-line")]
    public WavyLine WavyLine {
        get {
            return this._wavyLineField;
        }
        set {
            this._wavyLineField = value;
        }
    }
    
    /// <remarks/>
    public EmptyPrintStyleAlign segno {
        get {
            return this.segnoField;
        }
        set {
            this.segnoField = value;
        }
    }
    
    /// <remarks/>
    public EmptyPrintStyleAlign coda {
        get {
            return this.codaField;
        }
        set {
            this.codaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("fermata")]
    public Fermata[] fermata {
        get {
            return this.fermataField;
        }
        set {
            this.fermataField = value;
        }
    }
    
    /// <remarks/>
    public Ending ending {
        get {
            return this.endingField;
        }
        set {
            this.endingField = value;
        }
    }
    
    /// <remarks/>
    public Repeat repeat {
        get {
            return this.repeatField;
        }
        set {
            this.repeatField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(RightLeftMiddle.right)]
    public RightLeftMiddle location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("segno", DataType="token")]
    public string segno1 {
        get {
            return this.segno1Field;
        }
        set {
            this.segno1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("coda", DataType="token")]
    public string coda1 {
        get {
            return this.coda1Field;
        }
        set {
            this.coda1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal divisions {
        get {
            return this.divisionsField;
        }
        set {
            this.divisionsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool divisionsSpecified {
        get {
            return this.divisionsFieldSpecified;
        }
        set {
            this.divisionsFieldSpecified = value;
        }
    }
}