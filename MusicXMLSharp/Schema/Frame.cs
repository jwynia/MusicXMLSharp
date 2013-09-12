/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Frame {
    
    private string framestringsField;
    
    private string framefretsField;
    
    private FirstFret _firstFretField;
    
    private FrameNote[] _frameNoteField;
    
    private decimal defaultxField;
    
    private bool defaultxFieldSpecified;
    
    private decimal defaultyField;
    
    private bool defaultyFieldSpecified;
    
    private decimal relativexField;
    
    private bool relativexFieldSpecified;
    
    private decimal relativeyField;
    
    private bool relativeyFieldSpecified;
    
    private string colorField;
    
    private LeftCenterRight halignField;
    
    private bool halignFieldSpecified;
    
    private ValignImage valignField;
    
    private bool valignFieldSpecified;
    
    private decimal heightField;
    
    private bool heightFieldSpecified;
    
    private decimal widthField;
    
    private bool widthFieldSpecified;
    
    private string unplayedField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("frame-strings", DataType="positiveInteger")]
    public string framestrings {
        get {
            return this.framestringsField;
        }
        set {
            this.framestringsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("frame-frets", DataType="positiveInteger")]
    public string framefrets {
        get {
            return this.framefretsField;
        }
        set {
            this.framefretsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("first-fret")]
    public FirstFret FirstFret {
        get {
            return this._firstFretField;
        }
        set {
            this._firstFretField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("frame-note")]
    public FrameNote[] FrameNote {
        get {
            return this._frameNoteField;
        }
        set {
            this._frameNoteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
    public decimal defaultx {
        get {
            return this.defaultxField;
        }
        set {
            this.defaultxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool defaultxSpecified {
        get {
            return this.defaultxFieldSpecified;
        }
        set {
            this.defaultxFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
    public decimal defaulty {
        get {
            return this.defaultyField;
        }
        set {
            this.defaultyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool defaultySpecified {
        get {
            return this.defaultyFieldSpecified;
        }
        set {
            this.defaultyFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
    public decimal relativex {
        get {
            return this.relativexField;
        }
        set {
            this.relativexField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool relativexSpecified {
        get {
            return this.relativexFieldSpecified;
        }
        set {
            this.relativexFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
    public decimal relativey {
        get {
            return this.relativeyField;
        }
        set {
            this.relativeyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool relativeySpecified {
        get {
            return this.relativeyFieldSpecified;
        }
        set {
            this.relativeyFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    public string color {
        get {
            return this.colorField;
        }
        set {
            this.colorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public LeftCenterRight halign {
        get {
            return this.halignField;
        }
        set {
            this.halignField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool halignSpecified {
        get {
            return this.halignFieldSpecified;
        }
        set {
            this.halignFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ValignImage valign {
        get {
            return this.valignField;
        }
        set {
            this.valignField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valignSpecified {
        get {
            return this.valignFieldSpecified;
        }
        set {
            this.valignFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal height {
        get {
            return this.heightField;
        }
        set {
            this.heightField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool heightSpecified {
        get {
            return this.heightFieldSpecified;
        }
        set {
            this.heightFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal width {
        get {
            return this.widthField;
        }
        set {
            this.widthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool widthSpecified {
        get {
            return this.widthFieldSpecified;
        }
        set {
            this.widthFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    public string unplayed {
        get {
            return this.unplayedField;
        }
        set {
            this.unplayedField = value;
        }
    }
}