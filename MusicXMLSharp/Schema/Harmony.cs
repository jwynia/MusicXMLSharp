using MusicXMLSharp.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Harmony {
    
    private object[] itemsField;
    
    private Kind[] kindField;
    
    private Inversion[] inversionField;
    
    private Bass[] bassField;
    
    private Degree[] degreeField;
    
    private Frame frameField;
    
    private Offset offsetField;
    
    private FormattedText footnoteField;
    
    private Level levelField;
    
    private string staffField;
    
    private HarmonyType typeField;
    
    private bool typeFieldSpecified;
    
    private YesNo printobjectField;
    
    private bool printobjectFieldSpecified;
    
    private YesNo printframeField;
    
    private bool printframeFieldSpecified;
    
    private AboveBelow placementField;
    
    private bool placementFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("function", typeof(StyleText))]
    [System.Xml.Serialization.XmlElementAttribute("root", typeof(Root))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("kind")]
    public Kind[] kind {
        get {
            return this.kindField;
        }
        set {
            this.kindField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("inversion")]
    public Inversion[] inversion {
        get {
            return this.inversionField;
        }
        set {
            this.inversionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bass")]
    public Bass[] bass {
        get {
            return this.bassField;
        }
        set {
            this.bassField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("degree")]
    public Degree[] degree {
        get {
            return this.degreeField;
        }
        set {
            this.degreeField = value;
        }
    }
    
    /// <remarks/>
    public Frame frame {
        get {
            return this.frameField;
        }
        set {
            this.frameField = value;
        }
    }
    
    /// <remarks/>
    public Offset offset {
        get {
            return this.offsetField;
        }
        set {
            this.offsetField = value;
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
    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string staff {
        get {
            return this.staffField;
        }
        set {
            this.staffField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public HarmonyType type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool typeSpecified {
        get {
            return this.typeFieldSpecified;
        }
        set {
            this.typeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
    public YesNo printobject {
        get {
            return this.printobjectField;
        }
        set {
            this.printobjectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool printobjectSpecified {
        get {
            return this.printobjectFieldSpecified;
        }
        set {
            this.printobjectFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("print-frame")]
    public YesNo printframe {
        get {
            return this.printframeField;
        }
        set {
            this.printframeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool printframeSpecified {
        get {
            return this.printframeFieldSpecified;
        }
        set {
            this.printframeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public AboveBelow placement {
        get {
            return this.placementField;
        }
        set {
            this.placementField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool placementSpecified {
        get {
            return this.placementFieldSpecified;
        }
        set {
            this.placementFieldSpecified = value;
        }
    }
}