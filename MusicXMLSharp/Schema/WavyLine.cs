using MusicXMLSharp.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="wavy-line")]
public partial class WavyLine {
    
    private StartStopContinue typeField;
    
    private string numberField;
    
    private decimal defaultxField;
    
    private bool defaultxFieldSpecified;
    
    private decimal defaultyField;
    
    private bool defaultyFieldSpecified;
    
    private decimal relativexField;
    
    private bool relativexFieldSpecified;
    
    private decimal relativeyField;
    
    private bool relativeyFieldSpecified;
    
    private AboveBelow placementField;
    
    private bool placementFieldSpecified;
    
    private string colorField;
    
    private StartNote _startNoteField;
    
    private bool startnoteFieldSpecified;
    
    private TrillStep _trillStepField;
    
    private bool trillstepFieldSpecified;
    
    private TwoNoteTurn _twoNoteTurnField;
    
    private bool twonoteturnFieldSpecified;
    
    private YesNo accelerateField;
    
    private bool accelerateFieldSpecified;
    
    private decimal beatsField;
    
    private bool beatsFieldSpecified;
    
    private decimal secondbeatField;
    
    private bool secondbeatFieldSpecified;
    
    private decimal lastbeatField;
    
    private bool lastbeatFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public StartStopContinue type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
    public string number {
        get {
            return this.numberField;
        }
        set {
            this.numberField = value;
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
    [System.Xml.Serialization.XmlAttributeAttribute("start-note")]
    public StartNote StartNote {
        get {
            return this._startNoteField;
        }
        set {
            this._startNoteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startnoteSpecified {
        get {
            return this.startnoteFieldSpecified;
        }
        set {
            this.startnoteFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("trill-step")]
    public TrillStep TrillStep {
        get {
            return this._trillStepField;
        }
        set {
            this._trillStepField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool trillstepSpecified {
        get {
            return this.trillstepFieldSpecified;
        }
        set {
            this.trillstepFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("two-note-turn")]
    public TwoNoteTurn TwoNoteTurn {
        get {
            return this._twoNoteTurnField;
        }
        set {
            this._twoNoteTurnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool twonoteturnSpecified {
        get {
            return this.twonoteturnFieldSpecified;
        }
        set {
            this.twonoteturnFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public YesNo accelerate {
        get {
            return this.accelerateField;
        }
        set {
            this.accelerateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool accelerateSpecified {
        get {
            return this.accelerateFieldSpecified;
        }
        set {
            this.accelerateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal beats {
        get {
            return this.beatsField;
        }
        set {
            this.beatsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool beatsSpecified {
        get {
            return this.beatsFieldSpecified;
        }
        set {
            this.beatsFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("second-beat")]
    public decimal secondbeat {
        get {
            return this.secondbeatField;
        }
        set {
            this.secondbeatField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool secondbeatSpecified {
        get {
            return this.secondbeatFieldSpecified;
        }
        set {
            this.secondbeatFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("last-beat")]
    public decimal lastbeat {
        get {
            return this.lastbeatField;
        }
        set {
            this.lastbeatField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool lastbeatSpecified {
        get {
            return this.lastbeatFieldSpecified;
        }
        set {
            this.lastbeatFieldSpecified = value;
        }
    }
}