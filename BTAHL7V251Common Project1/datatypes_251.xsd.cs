namespace BTAHL7Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://microsoft.com/HealthCare/HL7/2X/2.5.1/DataTypes",@"HL7DefinedDataTypes")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"HL7DefinedDataTypes"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTAHL7Schemas.tablevalues_251", typeof(global::BTAHL7Schemas.tablevalues_251))]
    public sealed class datatypes_251 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://microsoft.com/HealthCare/HL7/2X/2.5.1/DataTypes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://microsoft.com/HealthCare/HL7/2X/2.5.1/Tables"" targetNamespace=""http://microsoft.com/HealthCare/HL7/2X/2.5.1/DataTypes"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""BTAHL7Schemas.tablevalues_251"" namespace=""http://microsoft.com/HealthCare/HL7/2X/2.5.1/Tables"" />
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo standards_version=""HL7.DBVersion.1_5"" document_type=""HL7 2X Schema"" version=""0.0.0.0.2.0"" root_reference=""HL7DefinedDataTypes"" />
      <b:references>
        <b:reference targetNamespace=""http://microsoft.com/HealthCare/HL7/2X/2.5.1/Tables"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:simpleType name=""ID_202"">
    <xs:restriction base=""ns0:Table202"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_201"">
    <xs:restriction base=""ns0:Table201"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_204"">
    <xs:restriction base=""ns0:Table204"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_288"">
    <xs:restriction base=""ns0:Table288"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_104"">
    <xs:restriction base=""ns0:Table104"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_267"">
    <xs:restriction base=""ns0:Table267"" />
  </xs:simpleType>
  <xs:simpleType name=""TX_256"">
    <xs:restriction base=""ns0:Table256"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_529"">
    <xs:restriction base=""ns0:Table529"" />
  </xs:simpleType>
  <xs:simpleType name=""DTM"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_8_301"">
    <xs:restriction base=""ns0:Table301"" />
  </xs:simpleType>
  <xs:simpleType name=""NM_6"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""IS_4_363"">
    <xs:restriction base=""ns0:Table363"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_2_363"">
    <xs:restriction base=""ns0:Table363"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_0_524"">
    <xs:restriction base=""ns0:Table524"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_472"">
    <xs:restriction base=""ns0:Table472"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_0_335"">
    <xs:restriction base=""ns0:Table335"" />
  </xs:simpleType>
  <xs:simpleType name=""CE_1"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""TM"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_397"">
    <xs:restriction base=""ns0:Table397"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_337"">
    <xs:restriction base=""ns0:Table337"" />
  </xs:simpleType>
  <xs:simpleType name=""SI"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""[+]?[\d]+"" />
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""GTS"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_528"">
    <xs:restriction base=""ns0:Table528"" />
  </xs:simpleType>
  <xs:simpleType name=""IS"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_527"">
    <xs:restriction base=""ns0:Table527"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_146"">
    <xs:restriction base=""ns0:Table146"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_145"">
    <xs:restriction base=""ns0:Table145"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_440"">
    <xs:restriction base=""ns0:Table440"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_210"">
    <xs:restriction base=""ns0:Table210"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_209"">
    <xs:restriction base=""ns0:Table209"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_2"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_0_148"">
    <xs:restriction base=""ns0:Table148"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_193"">
    <xs:restriction base=""ns0:Table193"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_147"">
    <xs:restriction base=""ns0:Table147"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_207"">
    <xs:restriction base=""ns0:Table207"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_103"">
    <xs:restriction base=""ns0:Table103"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_444"">
    <xs:restriction base=""ns0:Table444"" />
  </xs:simpleType>
  <xs:simpleType name=""TS_1"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""TS_0"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_465"">
    <xs:restriction base=""ns0:Table465"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_200"">
    <xs:restriction base=""ns0:Table200"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_297"">
    <xs:restriction base=""ns0:Table297"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_338"">
    <xs:restriction base=""ns0:Table338"" />
  </xs:simpleType>
  <xs:simpleType name=""NUL"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_10_301"">
    <xs:restriction base=""ns0:Table301"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_9"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""IS_8_363"">
    <xs:restriction base=""ns0:Table363"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_7_297"">
    <xs:restriction base=""ns0:Table297"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_6_360"">
    <xs:restriction base=""ns0:Table360"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_5"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_354"">
    <xs:restriction base=""ns0:Table354"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_76"">
    <xs:restriction base=""ns0:Table76"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_148"">
    <xs:restriction base=""ns0:Table148"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_190"">
    <xs:restriction base=""ns0:Table190"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_6_190"">
    <xs:restriction base=""ns0:Table190"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_5_399"">
    <xs:restriction base=""ns0:Table399"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_308"">
    <xs:restriction base=""ns0:Table308"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_307"">
    <xs:restriction base=""ns0:Table307"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_305"">
    <xs:restriction base=""ns0:Table305"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_306"">
    <xs:restriction base=""ns0:Table306"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_304"">
    <xs:restriction base=""ns0:Table304"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_303"">
    <xs:restriction base=""ns0:Table303"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_302"">
    <xs:restriction base=""ns0:Table302"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_328"">
    <xs:restriction base=""ns0:Table328"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_327"">
    <xs:restriction base=""ns0:Table327"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_548"">
    <xs:restriction base=""ns0:Table548"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_535"">
    <xs:restriction base=""ns0:Table535"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_534"">
    <xs:restriction base=""ns0:Table534"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_517"">
    <xs:restriction base=""ns0:Table517"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_507"">
    <xs:restriction base=""ns0:Table507"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_473"">
    <xs:restriction base=""ns0:Table473"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_470"">
    <xs:restriction base=""ns0:Table470"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_469"">
    <xs:restriction base=""ns0:Table469"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_468"">
    <xs:restriction base=""ns0:Table468"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_467"">
    <xs:restriction base=""ns0:Table467"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_460"">
    <xs:restriction base=""ns0:Table460"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_459"">
    <xs:restriction base=""ns0:Table459"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_458"">
    <xs:restriction base=""ns0:Table458"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_457"">
    <xs:restriction base=""ns0:Table457"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_456"">
    <xs:restriction base=""ns0:Table456"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_455"">
    <xs:restriction base=""ns0:Table455"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_445"">
    <xs:restriction base=""ns0:Table445"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_442"">
    <xs:restriction base=""ns0:Table442"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_441"">
    <xs:restriction base=""ns0:Table441"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_416"">
    <xs:restriction base=""ns0:Table416"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_415"">
    <xs:restriction base=""ns0:Table415"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_409"">
    <xs:restriction base=""ns0:Table409"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_392"">
    <xs:restriction base=""ns0:Table392"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_360"">
    <xs:restriction base=""ns0:Table360"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_335"">
    <xs:restriction base=""ns0:Table335"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_334"">
    <xs:restriction base=""ns0:Table334"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_326"">
    <xs:restriction base=""ns0:Table326"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_320"">
    <xs:restriction base=""ns0:Table320"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_319"">
    <xs:restriction base=""ns0:Table319"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_316"">
    <xs:restriction base=""ns0:Table316"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_315"">
    <xs:restriction base=""ns0:Table315"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_313"">
    <xs:restriction base=""ns0:Table313"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_312"">
    <xs:restriction base=""ns0:Table312"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_311"">
    <xs:restriction base=""ns0:Table311"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_309"">
    <xs:restriction base=""ns0:Table309"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_295"">
    <xs:restriction base=""ns0:Table295"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_289"">
    <xs:restriction base=""ns0:Table289"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_279"">
    <xs:restriction base=""ns0:Table279"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_270"">
    <xs:restriction base=""ns0:Table270"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_269"">
    <xs:restriction base=""ns0:Table269"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_268"">
    <xs:restriction base=""ns0:Table268"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_261"">
    <xs:restriction base=""ns0:Table261"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_260"">
    <xs:restriction base=""ns0:Table260"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_249"">
    <xs:restriction base=""ns0:Table249"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_246"">
    <xs:restriction base=""ns0:Table246"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_245"">
    <xs:restriction base=""ns0:Table245"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_244"">
    <xs:restriction base=""ns0:Table244"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_232"">
    <xs:restriction base=""ns0:Table232"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_231"">
    <xs:restriction base=""ns0:Table231"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_230"">
    <xs:restriction base=""ns0:Table230"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_229"">
    <xs:restriction base=""ns0:Table229"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_228"">
    <xs:restriction base=""ns0:Table228"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_223"">
    <xs:restriction base=""ns0:Table223"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_222"">
    <xs:restriction base=""ns0:Table222"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_220"">
    <xs:restriction base=""ns0:Table220"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_219"">
    <xs:restriction base=""ns0:Table219"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_217"">
    <xs:restriction base=""ns0:Table217"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_216"">
    <xs:restriction base=""ns0:Table216"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_215"">
    <xs:restriction base=""ns0:Table215"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_214"">
    <xs:restriction base=""ns0:Table214"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_213"">
    <xs:restriction base=""ns0:Table213"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_186"">
    <xs:restriction base=""ns0:Table186"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_182"">
    <xs:restriction base=""ns0:Table182"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_174"">
    <xs:restriction base=""ns0:Table174"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_173"">
    <xs:restriction base=""ns0:Table173"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_152"">
    <xs:restriction base=""ns0:Table152"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_151"">
    <xs:restriction base=""ns0:Table151"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_144"">
    <xs:restriction base=""ns0:Table144"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_143"">
    <xs:restriction base=""ns0:Table143"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_142"">
    <xs:restriction base=""ns0:Table142"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_141"">
    <xs:restriction base=""ns0:Table141"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_140"">
    <xs:restriction base=""ns0:Table140"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_139"">
    <xs:restriction base=""ns0:Table139"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_137"">
    <xs:restriction base=""ns0:Table137"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_135"">
    <xs:restriction base=""ns0:Table135"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_130"">
    <xs:restriction base=""ns0:Table130"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_117"">
    <xs:restriction base=""ns0:Table117"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_116"">
    <xs:restriction base=""ns0:Table116"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_115"">
    <xs:restriction base=""ns0:Table115"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_112"">
    <xs:restriction base=""ns0:Table112"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_111"">
    <xs:restriction base=""ns0:Table111"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_110"">
    <xs:restriction base=""ns0:Table110"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_99"">
    <xs:restriction base=""ns0:Table99"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_98"">
    <xs:restriction base=""ns0:Table98"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_93"">
    <xs:restriction base=""ns0:Table93"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_92"">
    <xs:restriction base=""ns0:Table92"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_89"">
    <xs:restriction base=""ns0:Table89"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_87"">
    <xs:restriction base=""ns0:Table87"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_86"">
    <xs:restriction base=""ns0:Table86"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_78"">
    <xs:restriction base=""ns0:Table78"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_73"">
    <xs:restriction base=""ns0:Table73"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_72"">
    <xs:restriction base=""ns0:Table72"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_69"">
    <xs:restriction base=""ns0:Table69"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_68"">
    <xs:restriction base=""ns0:Table68"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_66"">
    <xs:restriction base=""ns0:Table66"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_63"">
    <xs:restriction base=""ns0:Table63"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_62"">
    <xs:restriction base=""ns0:Table62"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_56"">
    <xs:restriction base=""ns0:Table56"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_52"">
    <xs:restriction base=""ns0:Table52"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_46"">
    <xs:restriction base=""ns0:Table46"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_45"">
    <xs:restriction base=""ns0:Table45"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_44"">
    <xs:restriction base=""ns0:Table44"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_43"">
    <xs:restriction base=""ns0:Table43"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_42"">
    <xs:restriction base=""ns0:Table42"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_32"">
    <xs:restriction base=""ns0:Table32"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_24"">
    <xs:restriction base=""ns0:Table24"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_23"">
    <xs:restriction base=""ns0:Table23"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_22"">
    <xs:restriction base=""ns0:Table22"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_21"">
    <xs:restriction base=""ns0:Table21"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_19"">
    <xs:restriction base=""ns0:Table19"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_18"">
    <xs:restriction base=""ns0:Table18"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_17"">
    <xs:restriction base=""ns0:Table17"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_9"">
    <xs:restriction base=""ns0:Table9"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_7"">
    <xs:restriction base=""ns0:Table7"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_4"">
    <xs:restriction base=""ns0:Table4"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_1"">
    <xs:restriction base=""ns0:Table1"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_516"">
    <xs:restriction base=""ns0:Table516"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_511"">
    <xs:restriction base=""ns0:Table511"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_506"">
    <xs:restriction base=""ns0:Table506"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_505"">
    <xs:restriction base=""ns0:Table505"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_504"">
    <xs:restriction base=""ns0:Table504"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_503"">
    <xs:restriction base=""ns0:Table503"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_500"">
    <xs:restriction base=""ns0:Table500"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_480"">
    <xs:restriction base=""ns0:Table480"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_478"">
    <xs:restriction base=""ns0:Table478"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_427"">
    <xs:restriction base=""ns0:Table427"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_418"">
    <xs:restriction base=""ns0:Table418"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_399"">
    <xs:restriction base=""ns0:Table399"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_398"">
    <xs:restriction base=""ns0:Table398"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_395"">
    <xs:restriction base=""ns0:Table395"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_359"">
    <xs:restriction base=""ns0:Table359"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_356"">
    <xs:restriction base=""ns0:Table356"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_355"">
    <xs:restriction base=""ns0:Table355"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_332"">
    <xs:restriction base=""ns0:Table332"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_331"">
    <xs:restriction base=""ns0:Table331"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_330"">
    <xs:restriction base=""ns0:Table330"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_329"">
    <xs:restriction base=""ns0:Table329"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_323"">
    <xs:restriction base=""ns0:Table323"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_322"">
    <xs:restriction base=""ns0:Table322"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_321"">
    <xs:restriction base=""ns0:Table321"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_296"">
    <xs:restriction base=""ns0:Table296"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_287"">
    <xs:restriction base=""ns0:Table287"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_275"">
    <xs:restriction base=""ns0:Table275"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_273"">
    <xs:restriction base=""ns0:Table273"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_272"">
    <xs:restriction base=""ns0:Table272"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_271"">
    <xs:restriction base=""ns0:Table271"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_253"">
    <xs:restriction base=""ns0:Table253"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_252"">
    <xs:restriction base=""ns0:Table252"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_251"">
    <xs:restriction base=""ns0:Table251"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_250"">
    <xs:restriction base=""ns0:Table250"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_248"">
    <xs:restriction base=""ns0:Table248"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_243"">
    <xs:restriction base=""ns0:Table243"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_242"">
    <xs:restriction base=""ns0:Table242"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_241"">
    <xs:restriction base=""ns0:Table241"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_240"">
    <xs:restriction base=""ns0:Table240"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_239"">
    <xs:restriction base=""ns0:Table239"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_238"">
    <xs:restriction base=""ns0:Table238"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_237"">
    <xs:restriction base=""ns0:Table237"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_236"">
    <xs:restriction base=""ns0:Table236"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_235"">
    <xs:restriction base=""ns0:Table235"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_234"">
    <xs:restriction base=""ns0:Table234"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_225"">
    <xs:restriction base=""ns0:Table225"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_224"">
    <xs:restriction base=""ns0:Table224"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_211"">
    <xs:restriction base=""ns0:Table211"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_208"">
    <xs:restriction base=""ns0:Table208"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_206"">
    <xs:restriction base=""ns0:Table206"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_187"">
    <xs:restriction base=""ns0:Table187"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_183"">
    <xs:restriction base=""ns0:Table183"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_180"">
    <xs:restriction base=""ns0:Table180"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_179"">
    <xs:restriction base=""ns0:Table179"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_178"">
    <xs:restriction base=""ns0:Table178"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_170"">
    <xs:restriction base=""ns0:Table170"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_169"">
    <xs:restriction base=""ns0:Table169"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_168"">
    <xs:restriction base=""ns0:Table168"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_167"">
    <xs:restriction base=""ns0:Table167"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_166"">
    <xs:restriction base=""ns0:Table166"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_161"">
    <xs:restriction base=""ns0:Table161"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_159"">
    <xs:restriction base=""ns0:Table159"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_158"">
    <xs:restriction base=""ns0:Table158"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_157"">
    <xs:restriction base=""ns0:Table157"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_156"">
    <xs:restriction base=""ns0:Table156"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_155"">
    <xs:restriction base=""ns0:Table155"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_125"">
    <xs:restriction base=""ns0:Table125"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_124"">
    <xs:restriction base=""ns0:Table124"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_123"">
    <xs:restriction base=""ns0:Table123"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_122"">
    <xs:restriction base=""ns0:Table122"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_121"">
    <xs:restriction base=""ns0:Table121"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_119"">
    <xs:restriction base=""ns0:Table119"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_109"">
    <xs:restriction base=""ns0:Table109"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_108"">
    <xs:restriction base=""ns0:Table108"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_107"">
    <xs:restriction base=""ns0:Table107"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_106"">
    <xs:restriction base=""ns0:Table106"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_105"">
    <xs:restriction base=""ns0:Table105"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_91"">
    <xs:restriction base=""ns0:Table91"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_85"">
    <xs:restriction base=""ns0:Table85"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_80"">
    <xs:restriction base=""ns0:Table80"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_74"">
    <xs:restriction base=""ns0:Table74"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_65"">
    <xs:restriction base=""ns0:Table65"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_53"">
    <xs:restriction base=""ns0:Table53"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_38"">
    <xs:restriction base=""ns0:Table38"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_27"">
    <xs:restriction base=""ns0:Table27"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_8"">
    <xs:restriction base=""ns0:Table8"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_3"">
    <xs:restriction base=""ns0:Table3"" />
  </xs:simpleType>
  <xs:simpleType name=""ID"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_136"">
    <xs:restriction base=""ns0:Table136"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_150"">
    <xs:restriction base=""ns0:Table150"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_300"">
    <xs:restriction base=""ns0:Table300"" />
  </xs:simpleType>
  <xs:simpleType name=""FT"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""IS_64"">
    <xs:restriction base=""ns0:Table64"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_3_301"">
    <xs:restriction base=""ns0:Table301"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_2"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""IS_1_363"">
    <xs:restriction base=""ns0:Table363"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_301"">
    <xs:restriction base=""ns0:Table301"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_363"">
    <xs:restriction base=""ns0:Table363"" />
  </xs:simpleType>
  <xs:simpleType name=""TX"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_299"">
    <xs:restriction base=""ns0:Table299"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_291"">
    <xs:restriction base=""ns0:Table291"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_191"">
    <xs:restriction base=""ns0:Table191"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_149"">
    <xs:restriction base=""ns0:Table149"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_523"">
    <xs:restriction base=""ns0:Table523"" />
  </xs:simpleType>
  <xs:simpleType name=""NM_1"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""IS_333"">
    <xs:restriction base=""ns0:Table333"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_113"">
    <xs:restriction base=""ns0:Table113"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_8"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ST_7"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ST_6"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_203"">
    <xs:restriction base=""ns0:Table203"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_2_301"">
    <xs:restriction base=""ns0:Table301"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_0_300"">
    <xs:restriction base=""ns0:Table300"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_61"">
    <xs:restriction base=""ns0:Table61"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_2_126"">
    <xs:restriction base=""ns0:Table126"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_298"">
    <xs:restriction base=""ns0:Table298"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_5_396"">
    <xs:restriction base=""ns0:Table396"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_4"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ST_3"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_2_396"">
    <xs:restriction base=""ns0:Table396"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_1"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ST_0"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""NM"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""[-+]?[\d]*|[-+]?[\d]+.[\d]*|[-+]?[\d]*.[\d]+"" />
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_205"">
    <xs:restriction base=""ns0:Table205"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_1"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""NM_0"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_396"">
    <xs:restriction base=""ns0:Table396"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_1_529"">
    <xs:restriction base=""ns0:Table529"" />
  </xs:simpleType>
  <xs:simpleType name=""DTM_0"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_100"">
    <xs:restriction base=""ns0:Table100"" />
  </xs:simpleType>
  <xs:simpleType name=""DT"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ST"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""HL7DefinedDataTypes"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""AUI"" type=""AUI"" />
        <xs:element name=""CCD_100"" type=""CCD_100"" />
        <xs:element name=""CE"" type=""CE"" />
        <xs:element name=""CE_1"" type=""CE_1"" />
        <xs:element name=""CE_114"" type=""CE_114"" />
        <xs:element name=""CE_118"" type=""CE_118"" />
        <xs:element name=""CE_127"" type=""CE_127"" />
        <xs:element name=""CE_128"" type=""CE_128"" />
        <xs:element name=""CE_129"" type=""CE_129"" />
        <xs:element name=""CE_131"" type=""CE_131"" />
        <xs:element name=""CE_132"" type=""CE_132"" />
        <xs:element name=""CE_136"" type=""CE_136"" />
        <xs:element name=""CE_160"" type=""CE_160"" />
        <xs:element name=""CE_162"" type=""CE_162"" />
        <xs:element name=""CE_164"" type=""CE_164"" />
        <xs:element name=""CE_171"" type=""CE_171"" />
        <xs:element name=""CE_172"" type=""CE_172"" />
        <xs:element name=""CE_175"" type=""CE_175"" />
        <xs:element name=""CE_181"" type=""CE_181"" />
        <xs:element name=""CE_182"" type=""CE_182"" />
        <xs:element name=""CE_184"" type=""CE_184"" />
        <xs:element name=""CE_185"" type=""CE_185"" />
        <xs:element name=""CE_189"" type=""CE_189"" />
        <xs:element name=""CE_2"" type=""CE_2"" />
        <xs:element name=""CE_212"" type=""CE_212"" />
        <xs:element name=""CE_215"" type=""CE_215"" />
        <xs:element name=""CE_218"" type=""CE_218"" />
        <xs:element name=""CE_222"" type=""CE_222"" />
        <xs:element name=""CE_227"" type=""CE_227"" />
        <xs:element name=""CE_233"" type=""CE_233"" />
        <xs:element name=""CE_247"" type=""CE_247"" />
        <xs:element name=""CE_254"" type=""CE_254"" />
        <xs:element name=""CE_255"" type=""CE_255"" />
        <xs:element name=""CE_258"" type=""CE_258"" />
        <xs:element name=""CE_259"" type=""CE_259"" />
        <xs:element name=""CE_264"" type=""CE_264"" />
        <xs:element name=""CE_265"" type=""CE_265"" />
        <xs:element name=""CE_276"" type=""CE_276"" />
        <xs:element name=""CE_277"" type=""CE_277"" />
        <xs:element name=""CE_278"" type=""CE_278"" />
        <xs:element name=""CE_280"" type=""CE_280"" />
        <xs:element name=""CE_281"" type=""CE_281"" />
        <xs:element name=""CE_282"" type=""CE_282"" />
        <xs:element name=""CE_283"" type=""CE_283"" />
        <xs:element name=""CE_284"" type=""CE_284"" />
        <xs:element name=""CE_285"" type=""CE_285"" />
        <xs:element name=""CE_286"" type=""CE_286"" />
        <xs:element name=""CE_292"" type=""CE_292"" />
        <xs:element name=""CE_293"" type=""CE_293"" />
        <xs:element name=""CE_296"" type=""CE_296"" />
        <xs:element name=""CE_305"" type=""CE_305"" />
        <xs:element name=""CE_324"" type=""CE_324"" />
        <xs:element name=""CE_325"" type=""CE_325"" />
        <xs:element name=""CE_336"" type=""CE_336"" />
        <xs:element name=""CE_339"" type=""CE_339"" />
        <xs:element name=""CE_340"" type=""CE_340"" />
        <xs:element name=""CE_341"" type=""CE_341"" />
        <xs:element name=""CE_342"" type=""CE_342"" />
        <xs:element name=""CE_343"" type=""CE_343"" />
        <xs:element name=""CE_344"" type=""CE_344"" />
        <xs:element name=""CE_345"" type=""CE_345"" />
        <xs:element name=""CE_346"" type=""CE_346"" />
        <xs:element name=""CE_347"" type=""CE_347"" />
        <xs:element name=""CE_348"" type=""CE_348"" />
        <xs:element name=""CE_349"" type=""CE_349"" />
        <xs:element name=""CE_351"" type=""CE_351"" />
        <xs:element name=""CE_357"" type=""CE_357"" />
        <xs:element name=""CE_358"" type=""CE_358"" />
        <xs:element name=""CE_364"" type=""CE_364"" />
        <xs:element name=""CE_365"" type=""CE_365"" />
        <xs:element name=""CE_366"" type=""CE_366"" />
        <xs:element name=""CE_367"" type=""CE_367"" />
        <xs:element name=""CE_368"" type=""CE_368"" />
        <xs:element name=""CE_370"" type=""CE_370"" />
        <xs:element name=""CE_373"" type=""CE_373"" />
        <xs:element name=""CE_374"" type=""CE_374"" />
        <xs:element name=""CE_375"" type=""CE_375"" />
        <xs:element name=""CE_377"" type=""CE_377"" />
        <xs:element name=""CE_378"" type=""CE_378"" />
        <xs:element name=""CE_379"" type=""CE_379"" />
        <xs:element name=""CE_380"" type=""CE_380"" />
        <xs:element name=""CE_381"" type=""CE_381"" />
        <xs:element name=""CE_382"" type=""CE_382"" />
        <xs:element name=""CE_383"" type=""CE_383"" />
        <xs:element name=""CE_384"" type=""CE_384"" />
        <xs:element name=""CE_385"" type=""CE_385"" />
        <xs:element name=""CE_386"" type=""CE_386"" />
        <xs:element name=""CE_387"" type=""CE_387"" />
        <xs:element name=""CE_388"" type=""CE_388"" />
        <xs:element name=""CE_389"" type=""CE_389"" />
        <xs:element name=""CE_393"" type=""CE_393"" />
        <xs:element name=""CE_394"" type=""CE_394"" />
        <xs:element name=""CE_401"" type=""CE_401"" />
        <xs:element name=""CE_402"" type=""CE_402"" />
        <xs:element name=""CE_403"" type=""CE_403"" />
        <xs:element name=""CE_404"" type=""CE_404"" />
        <xs:element name=""CE_405"" type=""CE_405"" />
        <xs:element name=""CE_406"" type=""CE_406"" />
        <xs:element name=""CE_411"" type=""CE_411"" />
        <xs:element name=""CE_412"" type=""CE_412"" />
        <xs:element name=""CE_413"" type=""CE_413"" />
        <xs:element name=""CE_414"" type=""CE_414"" />
        <xs:element name=""CE_417"" type=""CE_417"" />
        <xs:element name=""CE_421"" type=""CE_421"" />
        <xs:element name=""CE_422"" type=""CE_422"" />
        <xs:element name=""CE_423"" type=""CE_423"" />
        <xs:element name=""CE_424"" type=""CE_424"" />
        <xs:element name=""CE_425"" type=""CE_425"" />
        <xs:element name=""CE_426"" type=""CE_426"" />
        <xs:element name=""CE_427"" type=""CE_427"" />
        <xs:element name=""CE_428"" type=""CE_428"" />
        <xs:element name=""CE_429"" type=""CE_429"" />
        <xs:element name=""CE_430"" type=""CE_430"" />
        <xs:element name=""CE_431"" type=""CE_431"" />
        <xs:element name=""CE_432"" type=""CE_432"" />
        <xs:element name=""CE_433"" type=""CE_433"" />
        <xs:element name=""CE_434"" type=""CE_434"" />
        <xs:element name=""CE_435"" type=""CE_435"" />
        <xs:element name=""CE_436"" type=""CE_436"" />
        <xs:element name=""CE_437"" type=""CE_437"" />
        <xs:element name=""CE_438"" type=""CE_438"" />
        <xs:element name=""CE_443"" type=""CE_443"" />
        <xs:element name=""CE_446"" type=""CE_446"" />
        <xs:element name=""CE_447"" type=""CE_447"" />
        <xs:element name=""CE_450"" type=""CE_450"" />
        <xs:element name=""CE_451"" type=""CE_451"" />
        <xs:element name=""CE_452"" type=""CE_452"" />
        <xs:element name=""CE_453"" type=""CE_453"" />
        <xs:element name=""CE_454"" type=""CE_454"" />
        <xs:element name=""CE_461"" type=""CE_461"" />
        <xs:element name=""CE_462"" type=""CE_462"" />
        <xs:element name=""CE_463"" type=""CE_463"" />
        <xs:element name=""CE_464"" type=""CE_464"" />
        <xs:element name=""CE_466"" type=""CE_466"" />
        <xs:element name=""CE_471"" type=""CE_471"" />
        <xs:element name=""CE_474"" type=""CE_474"" />
        <xs:element name=""CE_48"" type=""CE_48"" />
        <xs:element name=""CE_49"" type=""CE_49"" />
        <xs:element name=""CE_5"" type=""CE_5"" />
        <xs:element name=""CE_50"" type=""CE_50"" />
        <xs:element name=""CE_51"" type=""CE_51"" />
        <xs:element name=""CE_537"" type=""CE_537"" />
        <xs:element name=""CE_55"" type=""CE_55"" />
        <xs:element name=""CE_59"" type=""CE_59"" />
        <xs:element name=""CE_6"" type=""CE_6"" />
        <xs:element name=""CE_63"" type=""CE_63"" />
        <xs:element name=""CE_66"" type=""CE_66"" />
        <xs:element name=""CE_69"" type=""CE_69"" />
        <xs:element name=""CE_72"" type=""CE_72"" />
        <xs:element name=""CE_83"" type=""CE_83"" />
        <xs:element name=""CE_88"" type=""CE_88"" />
        <xs:element name=""CE_9999"" type=""CE_9999"" />
        <xs:element name=""CNE"" type=""CNE"" />
        <xs:element name=""CNE_323"" type=""CNE_323"" />
        <xs:element name=""CNE_483"" type=""CNE_483"" />
        <xs:element name=""CNE_497"" type=""CNE_497"" />
        <xs:element name=""CNE_498"" type=""CNE_498"" />
        <xs:element name=""CNE_549"" type=""CNE_549"" />
        <xs:element name=""CP"" type=""CP"" />
        <xs:element name=""CQ"" type=""CQ"" />
        <xs:element name=""CQ_126"" type=""CQ_126"" />
        <xs:element name=""CWE"" type=""CWE"" />
        <xs:element name=""CWE_163"" type=""CWE_163"" />
        <xs:element name=""CWE_165"" type=""CWE_165"" />
        <xs:element name=""CWE_171"" type=""CWE_171"" />
        <xs:element name=""CWE_177"" type=""CWE_177"" />
        <xs:element name=""CWE_289"" type=""CWE_289"" />
        <xs:element name=""CWE_347"" type=""CWE_347"" />
        <xs:element name=""CWE_357"" type=""CWE_357"" />
        <xs:element name=""CWE_369"" type=""CWE_369"" />
        <xs:element name=""CWE_371"" type=""CWE_371"" />
        <xs:element name=""CWE_376"" type=""CWE_376"" />
        <xs:element name=""CWE_475"" type=""CWE_475"" />
        <xs:element name=""CWE_476"" type=""CWE_476"" />
        <xs:element name=""CWE_477"" type=""CWE_477"" />
        <xs:element name=""CWE_482"" type=""CWE_482"" />
        <xs:element name=""CWE_484"" type=""CWE_484"" />
        <xs:element name=""CWE_485"" type=""CWE_485"" />
        <xs:element name=""CWE_487"" type=""CWE_487"" />
        <xs:element name=""CWE_488"" type=""CWE_488"" />
        <xs:element name=""CWE_489"" type=""CWE_489"" />
        <xs:element name=""CWE_490"" type=""CWE_490"" />
        <xs:element name=""CWE_491"" type=""CWE_491"" />
        <xs:element name=""CWE_492"" type=""CWE_492"" />
        <xs:element name=""CWE_493"" type=""CWE_493"" />
        <xs:element name=""CWE_494"" type=""CWE_494"" />
        <xs:element name=""CWE_495"" type=""CWE_495"" />
        <xs:element name=""CWE_496"" type=""CWE_496"" />
        <xs:element name=""CWE_499"" type=""CWE_499"" />
        <xs:element name=""CWE_501"" type=""CWE_501"" />
        <xs:element name=""CWE_502"" type=""CWE_502"" />
        <xs:element name=""CWE_508"" type=""CWE_508"" />
        <xs:element name=""CWE_509"" type=""CWE_509"" />
        <xs:element name=""CWE_510"" type=""CWE_510"" />
        <xs:element name=""CWE_512"" type=""CWE_512"" />
        <xs:element name=""CWE_513"" type=""CWE_513"" />
        <xs:element name=""CWE_514"" type=""CWE_514"" />
        <xs:element name=""CWE_515"" type=""CWE_515"" />
        <xs:element name=""CWE_518"" type=""CWE_518"" />
        <xs:element name=""CWE_519"" type=""CWE_519"" />
        <xs:element name=""CWE_521"" type=""CWE_521"" />
        <xs:element name=""CWE_533"" type=""CWE_533"" />
        <xs:element name=""CWE_536"" type=""CWE_536"" />
        <xs:element name=""CWE_538"" type=""CWE_538"" />
        <xs:element name=""CWE_539"" type=""CWE_539"" />
        <xs:element name=""CWE_540"" type=""CWE_540"" />
        <xs:element name=""CWE_541"" type=""CWE_541"" />
        <xs:element name=""CWE_542"" type=""CWE_542"" />
        <xs:element name=""CWE_543"" type=""CWE_543"" />
        <xs:element name=""CWE_544"" type=""CWE_544"" />
        <xs:element name=""CWE_547"" type=""CWE_547"" />
        <xs:element name=""CWE_552"" type=""CWE_552"" />
        <xs:element name=""CX"" type=""CX"" />
        <xs:element name=""CX_203"" type=""CX_203"" />
        <xs:element name=""DDI"" type=""DDI"" />
        <xs:element name=""DIN_537"" type=""DIN_537"" />
        <xs:element name=""DLD_113"" type=""DLD_113"" />
        <xs:element name=""DLN"" type=""DLN"" />
        <xs:element name=""DLT"" type=""DLT"" />
        <xs:element name=""DR"" type=""DR"" />
        <xs:element name=""DT"" type=""DT"" />
        <xs:element name=""DTM"" type=""DTM"" />
        <xs:element name=""DTM_0"" type=""DTM_0"" />
        <xs:element name=""DTN"" type=""DTN"" />
        <xs:element name=""ED"" type=""ED"" />
        <xs:element name=""EI"" type=""EI"" />
        <xs:element name=""EIP"" type=""EIP"" />
        <xs:element name=""ELD"" type=""ELD"" />
        <xs:element name=""ERL"" type=""ERL"" />
        <xs:element name=""FC"" type=""FC"" />
        <xs:element name=""FC_64"" type=""FC_64"" />
        <xs:element name=""FT"" type=""FT"" />
        <xs:element name=""GTS"" type=""GTS"" />
        <xs:element name=""HD"" type=""HD"" />
        <xs:element name=""HD_361"" type=""HD_361"" />
        <xs:element name=""HD_362"" type=""HD_362"" />
        <xs:element name=""ICD"" type=""ICD"" />
        <xs:element name=""ID"" type=""ID"" />
        <xs:element name=""ID_0_148"" type=""ID_0_148"" />
        <xs:element name=""ID_0_524"" type=""ID_0_524"" />
        <xs:element name=""ID_1"" type=""ID_1"" />
        <xs:element name=""ID_1_529"" type=""ID_1_529"" />
        <xs:element name=""ID_10_301"" type=""ID_10_301"" />
        <xs:element name=""ID_100"" type=""ID_100"" />
        <xs:element name=""ID_103"" type=""ID_103"" />
        <xs:element name=""ID_104"" type=""ID_104"" />
        <xs:element name=""ID_105"" type=""ID_105"" />
        <xs:element name=""ID_106"" type=""ID_106"" />
        <xs:element name=""ID_107"" type=""ID_107"" />
        <xs:element name=""ID_108"" type=""ID_108"" />
        <xs:element name=""ID_109"" type=""ID_109"" />
        <xs:element name=""ID_119"" type=""ID_119"" />
        <xs:element name=""ID_121"" type=""ID_121"" />
        <xs:element name=""ID_122"" type=""ID_122"" />
        <xs:element name=""ID_123"" type=""ID_123"" />
        <xs:element name=""ID_124"" type=""ID_124"" />
        <xs:element name=""ID_125"" type=""ID_125"" />
        <xs:element name=""ID_136"" type=""ID_136"" />
        <xs:element name=""ID_148"" type=""ID_148"" />
        <xs:element name=""ID_155"" type=""ID_155"" />
        <xs:element name=""ID_156"" type=""ID_156"" />
        <xs:element name=""ID_157"" type=""ID_157"" />
        <xs:element name=""ID_158"" type=""ID_158"" />
        <xs:element name=""ID_159"" type=""ID_159"" />
        <xs:element name=""ID_161"" type=""ID_161"" />
        <xs:element name=""ID_166"" type=""ID_166"" />
        <xs:element name=""ID_167"" type=""ID_167"" />
        <xs:element name=""ID_168"" type=""ID_168"" />
        <xs:element name=""ID_169"" type=""ID_169"" />
        <xs:element name=""ID_170"" type=""ID_170"" />
        <xs:element name=""ID_178"" type=""ID_178"" />
        <xs:element name=""ID_179"" type=""ID_179"" />
        <xs:element name=""ID_180"" type=""ID_180"" />
        <xs:element name=""ID_183"" type=""ID_183"" />
        <xs:element name=""ID_187"" type=""ID_187"" />
        <xs:element name=""ID_190"" type=""ID_190"" />
        <xs:element name=""ID_191"" type=""ID_191"" />
        <xs:element name=""ID_2"" type=""ID_2"" />
        <xs:element name=""ID_2_126"" type=""ID_2_126"" />
        <xs:element name=""ID_2_301"" type=""ID_2_301"" />
        <xs:element name=""ID_2_396"" type=""ID_2_396"" />
        <xs:element name=""ID_200"" type=""ID_200"" />
        <xs:element name=""ID_201"" type=""ID_201"" />
        <xs:element name=""ID_202"" type=""ID_202"" />
        <xs:element name=""ID_203"" type=""ID_203"" />
        <xs:element name=""ID_205"" type=""ID_205"" />
        <xs:element name=""ID_206"" type=""ID_206"" />
        <xs:element name=""ID_207"" type=""ID_207"" />
        <xs:element name=""ID_208"" type=""ID_208"" />
        <xs:element name=""ID_209"" type=""ID_209"" />
        <xs:element name=""ID_210"" type=""ID_210"" />
        <xs:element name=""ID_211"" type=""ID_211"" />
        <xs:element name=""ID_224"" type=""ID_224"" />
        <xs:element name=""ID_225"" type=""ID_225"" />
        <xs:element name=""ID_234"" type=""ID_234"" />
        <xs:element name=""ID_235"" type=""ID_235"" />
        <xs:element name=""ID_236"" type=""ID_236"" />
        <xs:element name=""ID_237"" type=""ID_237"" />
        <xs:element name=""ID_238"" type=""ID_238"" />
        <xs:element name=""ID_239"" type=""ID_239"" />
        <xs:element name=""ID_240"" type=""ID_240"" />
        <xs:element name=""ID_241"" type=""ID_241"" />
        <xs:element name=""ID_242"" type=""ID_242"" />
        <xs:element name=""ID_243"" type=""ID_243"" />
        <xs:element name=""ID_248"" type=""ID_248"" />
        <xs:element name=""ID_250"" type=""ID_250"" />
        <xs:element name=""ID_251"" type=""ID_251"" />
        <xs:element name=""ID_252"" type=""ID_252"" />
        <xs:element name=""ID_253"" type=""ID_253"" />
        <xs:element name=""ID_267"" type=""ID_267"" />
        <xs:element name=""ID_27"" type=""ID_27"" />
        <xs:element name=""ID_271"" type=""ID_271"" />
        <xs:element name=""ID_272"" type=""ID_272"" />
        <xs:element name=""ID_273"" type=""ID_273"" />
        <xs:element name=""ID_275"" type=""ID_275"" />
        <xs:element name=""ID_287"" type=""ID_287"" />
        <xs:element name=""ID_291"" type=""ID_291"" />
        <xs:element name=""ID_296"" type=""ID_296"" />
        <xs:element name=""ID_298"" type=""ID_298"" />
        <xs:element name=""ID_299"" type=""ID_299"" />
        <xs:element name=""ID_3"" type=""ID_3"" />
        <xs:element name=""ID_3_301"" type=""ID_3_301"" />
        <xs:element name=""ID_301"" type=""ID_301"" />
        <xs:element name=""ID_321"" type=""ID_321"" />
        <xs:element name=""ID_322"" type=""ID_322"" />
        <xs:element name=""ID_323"" type=""ID_323"" />
        <xs:element name=""ID_329"" type=""ID_329"" />
        <xs:element name=""ID_330"" type=""ID_330"" />
        <xs:element name=""ID_331"" type=""ID_331"" />
        <xs:element name=""ID_332"" type=""ID_332"" />
        <xs:element name=""ID_337"" type=""ID_337"" />
        <xs:element name=""ID_354"" type=""ID_354"" />
        <xs:element name=""ID_355"" type=""ID_355"" />
        <xs:element name=""ID_356"" type=""ID_356"" />
        <xs:element name=""ID_359"" type=""ID_359"" />
        <xs:element name=""ID_38"" type=""ID_38"" />
        <xs:element name=""ID_395"" type=""ID_395"" />
        <xs:element name=""ID_396"" type=""ID_396"" />
        <xs:element name=""ID_397"" type=""ID_397"" />
        <xs:element name=""ID_398"" type=""ID_398"" />
        <xs:element name=""ID_399"" type=""ID_399"" />
        <xs:element name=""ID_418"" type=""ID_418"" />
        <xs:element name=""ID_427"" type=""ID_427"" />
        <xs:element name=""ID_440"" type=""ID_440"" />
        <xs:element name=""ID_444"" type=""ID_444"" />
        <xs:element name=""ID_465"" type=""ID_465"" />
        <xs:element name=""ID_472"" type=""ID_472"" />
        <xs:element name=""ID_478"" type=""ID_478"" />
        <xs:element name=""ID_480"" type=""ID_480"" />
        <xs:element name=""ID_5_396"" type=""ID_5_396"" />
        <xs:element name=""ID_5_399"" type=""ID_5_399"" />
        <xs:element name=""ID_500"" type=""ID_500"" />
        <xs:element name=""ID_503"" type=""ID_503"" />
        <xs:element name=""ID_504"" type=""ID_504"" />
        <xs:element name=""ID_505"" type=""ID_505"" />
        <xs:element name=""ID_506"" type=""ID_506"" />
        <xs:element name=""ID_511"" type=""ID_511"" />
        <xs:element name=""ID_516"" type=""ID_516"" />
        <xs:element name=""ID_523"" type=""ID_523"" />
        <xs:element name=""ID_527"" type=""ID_527"" />
        <xs:element name=""ID_528"" type=""ID_528"" />
        <xs:element name=""ID_529"" type=""ID_529"" />
        <xs:element name=""ID_53"" type=""ID_53"" />
        <xs:element name=""ID_6_190"" type=""ID_6_190"" />
        <xs:element name=""ID_61"" type=""ID_61"" />
        <xs:element name=""ID_65"" type=""ID_65"" />
        <xs:element name=""ID_74"" type=""ID_74"" />
        <xs:element name=""ID_76"" type=""ID_76"" />
        <xs:element name=""ID_8"" type=""ID_8"" />
        <xs:element name=""ID_8_301"" type=""ID_8_301"" />
        <xs:element name=""ID_80"" type=""ID_80"" />
        <xs:element name=""ID_85"" type=""ID_85"" />
        <xs:element name=""ID_91"" type=""ID_91"" />
        <xs:element name=""IS"" type=""IS"" />
        <xs:element name=""IS_0_300"" type=""IS_0_300"" />
        <xs:element name=""IS_0_335"" type=""IS_0_335"" />
        <xs:element name=""IS_1"" type=""IS_1"" />
        <xs:element name=""IS_1_363"" type=""IS_1_363"" />
        <xs:element name=""IS_110"" type=""IS_110"" />
        <xs:element name=""IS_111"" type=""IS_111"" />
        <xs:element name=""IS_112"" type=""IS_112"" />
        <xs:element name=""IS_113"" type=""IS_113"" />
        <xs:element name=""IS_115"" type=""IS_115"" />
        <xs:element name=""IS_116"" type=""IS_116"" />
        <xs:element name=""IS_117"" type=""IS_117"" />
        <xs:element name=""IS_130"" type=""IS_130"" />
        <xs:element name=""IS_135"" type=""IS_135"" />
        <xs:element name=""IS_137"" type=""IS_137"" />
        <xs:element name=""IS_139"" type=""IS_139"" />
        <xs:element name=""IS_140"" type=""IS_140"" />
        <xs:element name=""IS_141"" type=""IS_141"" />
        <xs:element name=""IS_142"" type=""IS_142"" />
        <xs:element name=""IS_143"" type=""IS_143"" />
        <xs:element name=""IS_144"" type=""IS_144"" />
        <xs:element name=""IS_145"" type=""IS_145"" />
        <xs:element name=""IS_146"" type=""IS_146"" />
        <xs:element name=""IS_147"" type=""IS_147"" />
        <xs:element name=""IS_149"" type=""IS_149"" />
        <xs:element name=""IS_150"" type=""IS_150"" />
        <xs:element name=""IS_151"" type=""IS_151"" />
        <xs:element name=""IS_152"" type=""IS_152"" />
        <xs:element name=""IS_17"" type=""IS_17"" />
        <xs:element name=""IS_173"" type=""IS_173"" />
        <xs:element name=""IS_174"" type=""IS_174"" />
        <xs:element name=""IS_18"" type=""IS_18"" />
        <xs:element name=""IS_182"" type=""IS_182"" />
        <xs:element name=""IS_186"" type=""IS_186"" />
        <xs:element name=""IS_19"" type=""IS_19"" />
        <xs:element name=""IS_193"" type=""IS_193"" />
        <xs:element name=""IS_2_363"" type=""IS_2_363"" />
        <xs:element name=""IS_204"" type=""IS_204"" />
        <xs:element name=""IS_21"" type=""IS_21"" />
        <xs:element name=""IS_213"" type=""IS_213"" />
        <xs:element name=""IS_214"" type=""IS_214"" />
        <xs:element name=""IS_215"" type=""IS_215"" />
        <xs:element name=""IS_216"" type=""IS_216"" />
        <xs:element name=""IS_217"" type=""IS_217"" />
        <xs:element name=""IS_219"" type=""IS_219"" />
        <xs:element name=""IS_22"" type=""IS_22"" />
        <xs:element name=""IS_220"" type=""IS_220"" />
        <xs:element name=""IS_222"" type=""IS_222"" />
        <xs:element name=""IS_223"" type=""IS_223"" />
        <xs:element name=""IS_228"" type=""IS_228"" />
        <xs:element name=""IS_229"" type=""IS_229"" />
        <xs:element name=""IS_23"" type=""IS_23"" />
        <xs:element name=""IS_230"" type=""IS_230"" />
        <xs:element name=""IS_231"" type=""IS_231"" />
        <xs:element name=""IS_232"" type=""IS_232"" />
        <xs:element name=""IS_24"" type=""IS_24"" />
        <xs:element name=""IS_244"" type=""IS_244"" />
        <xs:element name=""IS_245"" type=""IS_245"" />
        <xs:element name=""IS_246"" type=""IS_246"" />
        <xs:element name=""IS_249"" type=""IS_249"" />
        <xs:element name=""IS_260"" type=""IS_260"" />
        <xs:element name=""IS_261"" type=""IS_261"" />
        <xs:element name=""IS_268"" type=""IS_268"" />
        <xs:element name=""IS_269"" type=""IS_269"" />
        <xs:element name=""IS_270"" type=""IS_270"" />
        <xs:element name=""IS_279"" type=""IS_279"" />
        <xs:element name=""IS_288"" type=""IS_288"" />
        <xs:element name=""IS_289"" type=""IS_289"" />
        <xs:element name=""IS_295"" type=""IS_295"" />
        <xs:element name=""IS_297"" type=""IS_297"" />
        <xs:element name=""IS_300"" type=""IS_300"" />
        <xs:element name=""IS_302"" type=""IS_302"" />
        <xs:element name=""IS_303"" type=""IS_303"" />
        <xs:element name=""IS_304"" type=""IS_304"" />
        <xs:element name=""IS_305"" type=""IS_305"" />
        <xs:element name=""IS_306"" type=""IS_306"" />
        <xs:element name=""IS_307"" type=""IS_307"" />
        <xs:element name=""IS_308"" type=""IS_308"" />
        <xs:element name=""IS_309"" type=""IS_309"" />
        <xs:element name=""IS_311"" type=""IS_311"" />
        <xs:element name=""IS_312"" type=""IS_312"" />
        <xs:element name=""IS_313"" type=""IS_313"" />
        <xs:element name=""IS_315"" type=""IS_315"" />
        <xs:element name=""IS_316"" type=""IS_316"" />
        <xs:element name=""IS_319"" type=""IS_319"" />
        <xs:element name=""IS_32"" type=""IS_32"" />
        <xs:element name=""IS_320"" type=""IS_320"" />
        <xs:element name=""IS_326"" type=""IS_326"" />
        <xs:element name=""IS_327"" type=""IS_327"" />
        <xs:element name=""IS_328"" type=""IS_328"" />
        <xs:element name=""IS_333"" type=""IS_333"" />
        <xs:element name=""IS_334"" type=""IS_334"" />
        <xs:element name=""IS_335"" type=""IS_335"" />
        <xs:element name=""IS_338"" type=""IS_338"" />
        <xs:element name=""IS_360"" type=""IS_360"" />
        <xs:element name=""IS_363"" type=""IS_363"" />
        <xs:element name=""IS_392"" type=""IS_392"" />
        <xs:element name=""IS_4"" type=""IS_4"" />
        <xs:element name=""IS_4_363"" type=""IS_4_363"" />
        <xs:element name=""IS_409"" type=""IS_409"" />
        <xs:element name=""IS_415"" type=""IS_415"" />
        <xs:element name=""IS_416"" type=""IS_416"" />
        <xs:element name=""IS_42"" type=""IS_42"" />
        <xs:element name=""IS_43"" type=""IS_43"" />
        <xs:element name=""IS_44"" type=""IS_44"" />
        <xs:element name=""IS_441"" type=""IS_441"" />
        <xs:element name=""IS_442"" type=""IS_442"" />
        <xs:element name=""IS_445"" type=""IS_445"" />
        <xs:element name=""IS_45"" type=""IS_45"" />
        <xs:element name=""IS_455"" type=""IS_455"" />
        <xs:element name=""IS_456"" type=""IS_456"" />
        <xs:element name=""IS_457"" type=""IS_457"" />
        <xs:element name=""IS_458"" type=""IS_458"" />
        <xs:element name=""IS_459"" type=""IS_459"" />
        <xs:element name=""IS_46"" type=""IS_46"" />
        <xs:element name=""IS_460"" type=""IS_460"" />
        <xs:element name=""IS_467"" type=""IS_467"" />
        <xs:element name=""IS_468"" type=""IS_468"" />
        <xs:element name=""IS_469"" type=""IS_469"" />
        <xs:element name=""IS_470"" type=""IS_470"" />
        <xs:element name=""IS_473"" type=""IS_473"" />
        <xs:element name=""IS_507"" type=""IS_507"" />
        <xs:element name=""IS_517"" type=""IS_517"" />
        <xs:element name=""IS_52"" type=""IS_52"" />
        <xs:element name=""IS_534"" type=""IS_534"" />
        <xs:element name=""IS_535"" type=""IS_535"" />
        <xs:element name=""IS_548"" type=""IS_548"" />
        <xs:element name=""IS_56"" type=""IS_56"" />
        <xs:element name=""IS_6_360"" type=""IS_6_360"" />
        <xs:element name=""IS_62"" type=""IS_62"" />
        <xs:element name=""IS_63"" type=""IS_63"" />
        <xs:element name=""IS_64"" type=""IS_64"" />
        <xs:element name=""IS_66"" type=""IS_66"" />
        <xs:element name=""IS_68"" type=""IS_68"" />
        <xs:element name=""IS_69"" type=""IS_69"" />
        <xs:element name=""IS_7"" type=""IS_7"" />
        <xs:element name=""IS_7_297"" type=""IS_7_297"" />
        <xs:element name=""IS_72"" type=""IS_72"" />
        <xs:element name=""IS_73"" type=""IS_73"" />
        <xs:element name=""IS_78"" type=""IS_78"" />
        <xs:element name=""IS_8_363"" type=""IS_8_363"" />
        <xs:element name=""IS_86"" type=""IS_86"" />
        <xs:element name=""IS_87"" type=""IS_87"" />
        <xs:element name=""IS_89"" type=""IS_89"" />
        <xs:element name=""IS_9"" type=""IS_9"" />
        <xs:element name=""IS_92"" type=""IS_92"" />
        <xs:element name=""IS_93"" type=""IS_93"" />
        <xs:element name=""IS_98"" type=""IS_98"" />
        <xs:element name=""IS_99"" type=""IS_99"" />
        <xs:element name=""JCC"" type=""JCC"" />
        <xs:element name=""JCC_327"" type=""JCC_327"" />
        <xs:element name=""LA1"" type=""LA1"" />
        <xs:element name=""LA2"" type=""LA2"" />
        <xs:element name=""MO"" type=""MO"" />
        <xs:element name=""MOC"" type=""MOC"" />
        <xs:element name=""MOP"" type=""MOP"" />
        <xs:element name=""MSG"" type=""MSG"" />
        <xs:element name=""NA"" type=""NA"" />
        <xs:element name=""NDL"" type=""NDL"" />
        <xs:element name=""NM"" type=""NM"" />
        <xs:element name=""NM_0"" type=""NM_0"" />
        <xs:element name=""NM_1"" type=""NM_1"" />
        <xs:element name=""NM_6"" type=""NM_6"" />
        <xs:element name=""NUL"" type=""NUL"" />
        <xs:element name=""OCD"" type=""OCD"" />
        <xs:element name=""OSP"" type=""OSP"" />
        <xs:element name=""PIP"" type=""PIP"" />
        <xs:element name=""PL"" type=""PL"" />
        <xs:element name=""PLN"" type=""PLN"" />
        <xs:element name=""PLN_338"" type=""PLN_338"" />
        <xs:element name=""PPN"" type=""PPN"" />
        <xs:element name=""PRL"" type=""PRL"" />
        <xs:element name=""PT"" type=""PT"" />
        <xs:element name=""PTA"" type=""PTA"" />
        <xs:element name=""QIP"" type=""QIP"" />
        <xs:element name=""QSC"" type=""QSC"" />
        <xs:element name=""RCD_440"" type=""RCD_440"" />
        <xs:element name=""RFR"" type=""RFR"" />
        <xs:element name=""RI"" type=""RI"" />
        <xs:element name=""RMC"" type=""RMC"" />
        <xs:element name=""RPT_335"" type=""RPT_335"" />
        <xs:element name=""SCV"" type=""SCV"" />
        <xs:element name=""SCV_294"" type=""SCV_294"" />
        <xs:element name=""SI"" type=""SI"" />
        <xs:element name=""SN"" type=""SN"" />
        <xs:element name=""SPD_337"" type=""SPD_337"" />
        <xs:element name=""SPS"" type=""SPS"" />
        <xs:element name=""SRT"" type=""SRT"" />
        <xs:element name=""ST"" type=""ST"" />
        <xs:element name=""ST_0"" type=""ST_0"" />
        <xs:element name=""ST_1"" type=""ST_1"" />
        <xs:element name=""ST_2"" type=""ST_2"" />
        <xs:element name=""ST_3"" type=""ST_3"" />
        <xs:element name=""ST_4"" type=""ST_4"" />
        <xs:element name=""ST_5"" type=""ST_5"" />
        <xs:element name=""ST_6"" type=""ST_6"" />
        <xs:element name=""ST_7"" type=""ST_7"" />
        <xs:element name=""ST_8"" type=""ST_8"" />
        <xs:element name=""ST_9"" type=""ST_9"" />
        <xs:element name=""TM"" type=""TM"" />
        <xs:element name=""TQ"" type=""TQ"" />
        <xs:element name=""TS"" type=""TS"" />
        <xs:element name=""TS_0"" type=""TS_0"" />
        <xs:element name=""TS_1"" type=""TS_1"" />
        <xs:element name=""TX"" type=""TX"" />
        <xs:element name=""TX_256"" type=""TX_256"" />
        <xs:element name=""UVC"" type=""UVC"" />
        <xs:element name=""varies"" type=""varies"" />
        <xs:element name=""varies_9999"" type=""varies_9999"" />
        <xs:element name=""VH_267"" type=""VH_267"" />
        <xs:element name=""VID"" type=""VID"" />
        <xs:element name=""VR"" type=""VR"" />
        <xs:element name=""XAD"" type=""XAD"" />
        <xs:element name=""XCN"" type=""XCN"" />
        <xs:element name=""XCN_10"" type=""XCN_10"" />
        <xs:element name=""XCN_188"" type=""XCN_188"" />
        <xs:element name=""XCN_84"" type=""XCN_84"" />
        <xs:element name=""XON"" type=""XON"" />
        <xs:element name=""XPN"" type=""XPN"" />
        <xs:element name=""XTN"" type=""XTN"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""AUI"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""AUI_0_AuthorizationNumber"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""AUI_1_Date"" type=""DT"" />
      <xs:element minOccurs=""0"" name=""AUI_2_Source"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CCD_100"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CCD_0_InvocationEvent"" type=""ID_100"" />
      <xs:element minOccurs=""0"" name=""CCD_1_DateTime"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CCD_1_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""CCD_1_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_2"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_5"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_6"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_48"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_49"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_50"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_51"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_55"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_59"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_63"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_66"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_69"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_72"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_83"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_88"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_114"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_118"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_127"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_128"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_129"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_131"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_132"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_136"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_160"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_162"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_164"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_171"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_172"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_175"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_181"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_182"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_184"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_185"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_189"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_212"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_215"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_218"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_222"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_227"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_233"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_247"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_254"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_255"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_258"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_259"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_264"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_265"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_276"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_277"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_278"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_280"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_281"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_282"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_283"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_284"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_285"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_286"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_292"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_293"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_296"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_305"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_324"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_325"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_336"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_339"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_340"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_341"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_342"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_343"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_344"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_345"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_346"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_347"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_348"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_349"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_351"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_357"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_358"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_364"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_365"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_366"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_367"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_368"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_370"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_373"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_374"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_375"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_377"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_378"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_379"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_380"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_381"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_382"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_383"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_384"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_385"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_386"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_387"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_388"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_389"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_393"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_394"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_401"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_402"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_403"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_404"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_405"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_406"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_411"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_412"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_413"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_414"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_417"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_421"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_422"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_423"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_424"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_425"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_426"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_427"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_428"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_429"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_430"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_431"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_432"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_433"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_434"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_435"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_436"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_437"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_438"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_443"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_446"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_447"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_450"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_451"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_452"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_453"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_454"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_461"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_462"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_463"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_464"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_466"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_471"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_474"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_537"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_9999"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CNE"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CNE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CNE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CNE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CNE_323"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CNE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CNE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CNE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CNE_483"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CNE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CNE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CNE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CNE_497"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CNE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CNE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CNE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CNE_498"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CNE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CNE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CNE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CNE_549"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CNE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CNE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CNE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CP"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CP_0_Price"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CP_0_0_Quantity"" type=""NM_0"" />
            <xs:element minOccurs=""0"" name=""CP_0_1_Denomination"" type=""ID_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CP_1_PriceType"" type=""ID_205"" />
      <xs:element minOccurs=""0"" name=""CP_2_FromValue"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""CP_3_ToValue"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""CP_4_RangeUnits"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CP_4_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""CP_4_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""CP_4_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""CP_4_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""CP_4_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""CP_4_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CP_5_RangeType"" type=""ID_298"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CQ"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CQ_0_Quantity"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""CQ_1_Units"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CQ_1_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""CQ_1_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""CQ_1_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""CQ_1_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""CQ_1_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""CQ_1_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CQ_126"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CQ_0_Quantity"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""CQ_1_Units"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CQ_1_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""CQ_1_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""CQ_1_2_NameOfCodingSystem"" type=""ID_2_126"" />
            <xs:element minOccurs=""0"" name=""CQ_1_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""CQ_1_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""CQ_1_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_163"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_165"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_171"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_177"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_289"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_347"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_357"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_369"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_371"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_376"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_475"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_476"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_477"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_482"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_484"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_485"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_487"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_488"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_489"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_490"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_491"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_492"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_493"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_494"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_495"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_496"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_499"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_501"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_502"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_508"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_509"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_510"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_512"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_513"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_514"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_515"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_518"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_519"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_521"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_533"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_536"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_538"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_539"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_540"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_541"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_542"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_543"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_544"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_547"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_552"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CX"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CX_0_IdNumber"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CX_1_CheckDigit"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CX_2_CheckDigitScheme"" type=""ID_61"" />
      <xs:element minOccurs=""0"" name=""CX_3_AssigningAuthority"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CX_3_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""CX_3_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""CX_3_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CX_4_IdentifierTypeCode"" type=""ID_203"" />
      <xs:element minOccurs=""0"" name=""CX_5_AssigningFacility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CX_5_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""CX_5_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""CX_5_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CX_6_EffectiveDate"" type=""DT"" />
      <xs:element minOccurs=""0"" name=""CX_7_ExpirationDate"" type=""DT"" />
      <xs:element minOccurs=""0"" name=""CX_8_AssigningJurisdiction"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CX_8_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""CX_8_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""CX_8_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""CX_8_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""CX_8_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""CX_8_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""CX_8_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""CX_8_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""CX_8_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CX_9_AssigningAgencyOrDepartment"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CX_9_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""CX_9_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""CX_9_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""CX_9_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""CX_9_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""CX_9_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""CX_9_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""CX_9_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""CX_9_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CX_203"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CX_0_IdNumber"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CX_1_CheckDigit"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CX_2_CheckDigitScheme"" type=""ID_61"" />
      <xs:element minOccurs=""0"" name=""CX_3_AssigningAuthority"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CX_3_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""CX_3_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""CX_3_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CX_4_IdentifierTypeCode"" type=""ID_203"" />
      <xs:element minOccurs=""0"" name=""CX_5_AssigningFacility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CX_5_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""CX_5_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""CX_5_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CX_6_EffectiveDate"" type=""DT"" />
      <xs:element minOccurs=""0"" name=""CX_7_ExpirationDate"" type=""DT"" />
      <xs:element minOccurs=""0"" name=""CX_8_AssigningJurisdiction"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CX_8_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""CX_8_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""CX_8_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""CX_8_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""CX_8_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""CX_8_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""CX_8_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""CX_8_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""CX_8_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CX_9_AssigningAgencyOrDepartment"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CX_9_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""CX_9_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""CX_9_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""CX_9_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""CX_9_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""CX_9_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""CX_9_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""CX_9_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""CX_9_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""DDI"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DDI_0_DelayDays"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""DDI_1_MonetaryAmount"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""DDI_1_0_Quantity"" type=""NM_0"" />
            <xs:element minOccurs=""0"" name=""DDI_1_1_Denomination"" type=""ID_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DDI_2_NumberOfDays"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""DIN_537"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DIN_0_Date"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""DIN_0_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""DIN_0_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DIN_1_InstitutionName"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""DIN_1_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""DIN_1_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""DIN_1_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""DIN_1_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""DIN_1_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""DIN_1_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""DLD_113"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DLD_0_DischargeLocation"" type=""IS_113"" />
      <xs:element minOccurs=""0"" name=""DLD_1_EffectiveDate"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""DLD_1_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""DLD_1_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""DLN"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DLN_0_LicenseNumber"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""DLN_1_IssuingStateProvinceCountry"" type=""IS_333"" />
      <xs:element minOccurs=""0"" name=""DLN_2_ExpirationDate"" type=""DT"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""DLT"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DLT_0_NormalRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""DLT_0_0_LowValue"" type=""NM_0"" />
            <xs:element minOccurs=""0"" name=""DLT_0_1_HighValue"" type=""NM_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DLT_1_NumericThreshold"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""DLT_2_ChangeComputation"" type=""ID_523"" />
      <xs:element minOccurs=""0"" name=""DLT_3_DaysRetained"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""DR"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DR_0_RangeStartDateTime"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""DR_0_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""DR_0_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DR_1_RangeEndDateTime"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""DR_1_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""DR_1_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""DTN"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DTN_0_DayType"" type=""IS_149"" />
      <xs:element minOccurs=""0"" name=""DTN_1_NumberOfDays"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ED"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ED_0_SourceApplication"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""ED_0_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""ED_0_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""ED_0_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ED_1_TypeOfData"" type=""ID_191"" />
      <xs:element minOccurs=""0"" name=""ED_2_DataSubtype"" type=""ID_291"" />
      <xs:element minOccurs=""0"" name=""ED_3_Encoding"" type=""ID_299"" />
      <xs:element minOccurs=""0"" name=""ED_4_Data"" type=""TX"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""EI"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""EI_0_EntityIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""EI_1_NamespaceId"" type=""IS_363"" />
      <xs:element minOccurs=""0"" name=""EI_2_UniversalId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""EI_3_UniversalIdType"" type=""ID_301"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""EIP"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""EIP_0_PlacerAssignedIdentifier"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""EIP_0_0_EntityIdentifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""EIP_0_1_NamespaceId"" type=""IS_1_363"" />
            <xs:element minOccurs=""0"" name=""EIP_0_2_UniversalId"" type=""ST_2"" />
            <xs:element minOccurs=""0"" name=""EIP_0_3_UniversalIdType"" type=""ID_3_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""EIP_1_FillerAssignedIdentifier"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""EIP_1_0_EntityIdentifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""EIP_1_1_NamespaceId"" type=""IS_1_363"" />
            <xs:element minOccurs=""0"" name=""EIP_1_2_UniversalId"" type=""ST_2"" />
            <xs:element minOccurs=""0"" name=""EIP_1_3_UniversalIdType"" type=""ID_3_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ELD"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ELD_0_SegmentId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""ELD_1_SegmentSequence"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""ELD_2_FieldPosition"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""ELD_3_CodeIdentifyingError"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""ELD_3_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""ELD_3_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""ELD_3_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""ELD_3_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""ELD_3_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""ELD_3_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ERL"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ERL_0_SegmentId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""ERL_1_SegmentSequence"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""ERL_2_FieldPosition"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""ERL_3_FieldRepetition"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""ERL_4_ComponentNumber"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""ERL_5_SubComponentNumber"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""FC"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""FC_0_FinancialClassCode"" type=""IS_64"" />
      <xs:element minOccurs=""0"" name=""FC_1_EffectiveDate"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""FC_1_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""FC_1_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""FC_64"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""FC_0_FinancialClassCode"" type=""IS_64"" />
      <xs:element minOccurs=""0"" name=""FC_1_EffectiveDate"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""FC_1_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""FC_1_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""HD"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""HD_0_NamespaceId"" type=""IS_300"" />
      <xs:element minOccurs=""0"" name=""HD_1_UniversalId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""HD_2_UniversalIdType"" type=""ID_301"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""HD_361"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""HD_0_NamespaceId"" type=""IS_300"" />
      <xs:element minOccurs=""0"" name=""HD_1_UniversalId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""HD_2_UniversalIdType"" type=""ID_301"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""HD_362"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""HD_0_NamespaceId"" type=""IS_300"" />
      <xs:element minOccurs=""0"" name=""HD_1_UniversalId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""HD_2_UniversalIdType"" type=""ID_301"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ICD"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ICD_0_CertificationPatientType"" type=""IS_150"" />
      <xs:element minOccurs=""0"" name=""ICD_1_CertificationRequired"" type=""ID_136"" />
      <xs:element minOccurs=""0"" name=""ICD_2_DateTimeCertificationRequired"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""ICD_2_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""ICD_2_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""JCC"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""JCC_0_JobCode"" type=""IS_327"" />
      <xs:element minOccurs=""0"" name=""JCC_1_JobClass"" type=""IS_328"" />
      <xs:element minOccurs=""0"" name=""JCC_2_JobDescriptionText"" type=""TX"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""JCC_327"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""JCC_0_JobCode"" type=""IS_327"" />
      <xs:element minOccurs=""0"" name=""JCC_1_JobClass"" type=""IS_328"" />
      <xs:element minOccurs=""0"" name=""JCC_2_JobDescriptionText"" type=""TX"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""LA1"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""LA1_0_PointOfCare"" type=""IS_302"" />
      <xs:element minOccurs=""0"" name=""LA1_1_Room"" type=""IS_303"" />
      <xs:element minOccurs=""0"" name=""LA1_2_Bed"" type=""IS_304"" />
      <xs:element minOccurs=""0"" name=""LA1_3_Facility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""LA1_3_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""LA1_3_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""LA1_3_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""LA1_4_LocationStatus"" type=""IS_306"" />
      <xs:element minOccurs=""0"" name=""LA1_5_PatientLocationType"" type=""IS_305"" />
      <xs:element minOccurs=""0"" name=""LA1_6_Building"" type=""IS_307"" />
      <xs:element minOccurs=""0"" name=""LA1_7_Floor"" type=""IS_308"" />
      <xs:element minOccurs=""0"" name=""LA1_8_Address"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""LA1_8_0_StreetAddress"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""LA1_8_1_OtherDesignation"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""LA1_8_2_City"" type=""ST_2"" />
            <xs:element minOccurs=""0"" name=""LA1_8_3_StateOrProvince"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""LA1_8_4_ZipOrPostalCode"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""LA1_8_5_Country"" type=""ID_5_399"" />
            <xs:element minOccurs=""0"" name=""LA1_8_6_AddressType"" type=""ID_6_190"" />
            <xs:element minOccurs=""0"" name=""LA1_8_7_OtherGeographicDesignation"" type=""ST_7"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""LA2"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""LA2_0_PointOfCare"" type=""IS_302"" />
      <xs:element minOccurs=""0"" name=""LA2_1_Room"" type=""IS_303"" />
      <xs:element minOccurs=""0"" name=""LA2_2_Bed"" type=""IS_304"" />
      <xs:element minOccurs=""0"" name=""LA2_3_Facility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""LA2_3_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""LA2_3_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""LA2_3_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""LA2_4_LocationStatus"" type=""IS_306"" />
      <xs:element minOccurs=""0"" name=""LA2_5_PatientLocationType"" type=""IS_305"" />
      <xs:element minOccurs=""0"" name=""LA2_6_Building"" type=""IS_307"" />
      <xs:element minOccurs=""0"" name=""LA2_7_Floor"" type=""IS_308"" />
      <xs:element minOccurs=""0"" name=""LA2_8_StreetAddress"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""LA2_9_OtherDesignation"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""LA2_10_City"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""LA2_11_StateOrProvince"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""LA2_12_ZipOrPostalCode"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""LA2_13_Country"" type=""ID_399"" />
      <xs:element minOccurs=""0"" name=""LA2_14_AddressType"" type=""ID_190"" />
      <xs:element minOccurs=""0"" name=""LA2_15_OtherGeographicDesignation"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""MO"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""MO_0_Quantity"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""MO_1_Denomination"" type=""ID"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""MOC"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""MOC_0_MonetaryAmount"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""MOC_0_0_Quantity"" type=""NM_0"" />
            <xs:element minOccurs=""0"" name=""MOC_0_1_Denomination"" type=""ID_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""MOC_1_ChargeCode"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""MOC_1_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""MOC_1_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""MOC_1_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""MOC_1_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""MOC_1_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""MOC_1_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""MOP"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""MOP_0_MoneyOrPercentageIndicator"" type=""ID_148"" />
      <xs:element minOccurs=""0"" name=""MOP_1_MoneyOrPercentageQuantity"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""MOP_2_CurrencyDenomination"" type=""ID"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""MSG"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""MSG_0_MessageCode"" type=""ID_76"" />
      <xs:element minOccurs=""0"" name=""MSG_1_TriggerEvent"" type=""ID_3"" />
      <xs:element minOccurs=""0"" name=""MSG_2_MessageStructure"" type=""ID_354"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""NA"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""NA_0_Value1"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""NA_1_Value2"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""NA_2_Value3"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""NA_3_Value4"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""NDL"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""NDL_0_Name"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""NDL_0_0_IdNumber"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""NDL_0_1_FamilyName"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""NDL_0_2_GivenName"" type=""ST_2"" />
            <xs:element minOccurs=""0"" name=""NDL_0_3_SecondAndFurtherGivenNamesOrInitialsThereof"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""NDL_0_4_SuffixEGJrOrIii"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""NDL_0_5_PrefixEGDr"" type=""ST_5"" />
            <xs:element minOccurs=""0"" name=""NDL_0_6_DegreeEGMd"" type=""IS_6_360"" />
            <xs:element minOccurs=""0"" name=""NDL_0_7_SourceTable"" type=""IS_7_297"" />
            <xs:element minOccurs=""0"" name=""NDL_0_8_AssigningAuthorityNamespaceId"" type=""IS_8_363"" />
            <xs:element minOccurs=""0"" name=""NDL_0_9_AssigningAuthorityUniversalId"" type=""ST_9"" />
            <xs:element minOccurs=""0"" name=""NDL_0_10_AssigningAuthorityUniversalIdType"" type=""ID_10_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""NDL_1_StartDateTime"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""NDL_1_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""NDL_1_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""NDL_2_EndDateTime"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""NDL_2_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""NDL_2_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""NDL_3_PointOfCare"" type=""IS_302"" />
      <xs:element minOccurs=""0"" name=""NDL_4_Room"" type=""IS_303"" />
      <xs:element minOccurs=""0"" name=""NDL_5_Bed"" type=""IS_304"" />
      <xs:element minOccurs=""0"" name=""NDL_6_Facility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""NDL_6_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""NDL_6_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""NDL_6_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""NDL_7_LocationStatus"" type=""IS_306"" />
      <xs:element minOccurs=""0"" name=""NDL_8_PatientLocationType"" type=""IS_305"" />
      <xs:element minOccurs=""0"" name=""NDL_9_Building"" type=""IS_307"" />
      <xs:element minOccurs=""0"" name=""NDL_10_Floor"" type=""IS_308"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""OCD"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""OCD_0_OccurrenceCode"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""OCD_0_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""OCD_0_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""OCD_0_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""OCD_0_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""OCD_0_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""OCD_0_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""OCD_0_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""OCD_0_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""OCD_0_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""OCD_1_OccurrenceDate"" type=""DT"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""OSP"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""OSP_0_OccurrenceSpanCode"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""OSP_0_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""OSP_0_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""OSP_0_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""OSP_0_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""OSP_0_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""OSP_0_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""OSP_0_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""OSP_0_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""OSP_0_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""OSP_1_OccurrenceSpanStartDate"" type=""DT"" />
      <xs:element minOccurs=""0"" name=""OSP_2_OccurrenceSpanStopDate"" type=""DT"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PIP"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PIP_0_Privilege"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PIP_0_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""PIP_0_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""PIP_0_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""PIP_0_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""PIP_0_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""PIP_0_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PIP_1_PrivilegeClass"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PIP_1_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""PIP_1_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""PIP_1_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""PIP_1_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""PIP_1_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""PIP_1_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PIP_2_ExpirationDate"" type=""DT"" />
      <xs:element minOccurs=""0"" name=""PIP_3_ActivationDate"" type=""DT"" />
      <xs:element minOccurs=""0"" name=""PIP_4_Facility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PIP_4_0_EntityIdentifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""PIP_4_1_NamespaceId"" type=""IS_1_363"" />
            <xs:element minOccurs=""0"" name=""PIP_4_2_UniversalId"" type=""ST_2"" />
            <xs:element minOccurs=""0"" name=""PIP_4_3_UniversalIdType"" type=""ID_3_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PL"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PL_0_PointOfCare"" type=""IS_302"" />
      <xs:element minOccurs=""0"" name=""PL_1_Room"" type=""IS_303"" />
      <xs:element minOccurs=""0"" name=""PL_2_Bed"" type=""IS_304"" />
      <xs:element minOccurs=""0"" name=""PL_3_Facility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PL_3_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""PL_3_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""PL_3_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PL_4_LocationStatus"" type=""IS_306"" />
      <xs:element minOccurs=""0"" name=""PL_5_PersonLocationType"" type=""IS_305"" />
      <xs:element minOccurs=""0"" name=""PL_6_Building"" type=""IS_307"" />
      <xs:element minOccurs=""0"" name=""PL_7_Floor"" type=""IS_308"" />
      <xs:element minOccurs=""0"" name=""PL_8_LocationDescription"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PL_9_ComprehensiveLocationIdentifier"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PL_9_0_EntityIdentifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""PL_9_1_NamespaceId"" type=""IS_1_363"" />
            <xs:element minOccurs=""0"" name=""PL_9_2_UniversalId"" type=""ST_2"" />
            <xs:element minOccurs=""0"" name=""PL_9_3_UniversalIdType"" type=""ID_3_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PL_10_AssigningAuthorityForLocation"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PL_10_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""PL_10_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""PL_10_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PLN"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PLN_0_IdNumber"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PLN_1_TypeOfIdNumber"" type=""IS_338"" />
      <xs:element minOccurs=""0"" name=""PLN_2_StateOtherQualifyingInformation"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PLN_3_ExpirationDate"" type=""DT"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PLN_338"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PLN_0_IdNumber"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PLN_1_TypeOfIdNumber"" type=""IS_338"" />
      <xs:element minOccurs=""0"" name=""PLN_2_StateOtherQualifyingInformation"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PLN_3_ExpirationDate"" type=""DT"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PPN"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PPN_0_IdNumber"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PPN_1_FamilyName"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PPN_1_0_Surname"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""PPN_1_1_OwnSurnamePrefix"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""PPN_1_2_OwnSurname"" type=""ST_2"" />
            <xs:element minOccurs=""0"" name=""PPN_1_3_SurnamePrefixFromPartnerSpouse"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""PPN_1_4_SurnameFromPartnerSpouse"" type=""ST_4"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PPN_2_GivenName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PPN_3_SecondAndFurtherGivenNamesOrInitialsThereof"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PPN_4_SuffixEGJrOrIii"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PPN_5_PrefixEGDr"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PPN_6_DegreeEGMd"" type=""IS_360"" />
      <xs:element minOccurs=""0"" name=""PPN_7_SourceTable"" type=""IS_297"" />
      <xs:element minOccurs=""0"" name=""PPN_8_AssigningAuthority"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PPN_8_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""PPN_8_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""PPN_8_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PPN_9_NameTypeCode"" type=""ID_200"" />
      <xs:element minOccurs=""0"" name=""PPN_10_IdentifierCheckDigit"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PPN_11_CheckDigitScheme"" type=""ID_61"" />
      <xs:element minOccurs=""0"" name=""PPN_12_IdentifierTypeCode"" type=""ID_203"" />
      <xs:element minOccurs=""0"" name=""PPN_13_AssigningFacility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PPN_13_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""PPN_13_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""PPN_13_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PPN_14_DateTimeActionPerformed"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PPN_14_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""PPN_14_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PPN_15_NameRepresentationCode"" type=""ID_465"" />
      <xs:element minOccurs=""0"" name=""PPN_16_NameContext"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PPN_16_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""PPN_16_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""PPN_16_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""PPN_16_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""PPN_16_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""PPN_16_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PPN_17_NameValidityRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PPN_17_0_RangeStartDateTime"" type=""TS_0"" />
            <xs:element minOccurs=""0"" name=""PPN_17_1_RangeEndDateTime"" type=""TS_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PPN_18_NameAssemblyOrder"" type=""ID_444"" />
      <xs:element minOccurs=""0"" name=""PPN_19_EffectiveDate"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PPN_19_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""PPN_19_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PPN_20_ExpirationDate"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PPN_20_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""PPN_20_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PPN_21_ProfessionalSuffix"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PPN_22_AssigningJurisdiction"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PPN_22_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""PPN_22_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""PPN_22_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""PPN_22_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""PPN_22_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""PPN_22_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""PPN_22_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""PPN_22_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""PPN_22_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PPN_23_AssigningAgencyOrDepartment"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PPN_23_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""PPN_23_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""PPN_23_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""PPN_23_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""PPN_23_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""PPN_23_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""PPN_23_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""PPN_23_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""PPN_23_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PRL"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PRL_0_ParentObservationIdentifier"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PRL_0_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""PRL_0_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""PRL_0_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""PRL_0_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""PRL_0_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""PRL_0_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PRL_1_ParentObservationSubIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PRL_2_ParentObservationValueDescriptor"" type=""TX"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PT"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PT_0_ProcessingId"" type=""ID_103"" />
      <xs:element minOccurs=""0"" name=""PT_1_ProcessingMode"" type=""ID_207"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PTA"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PTA_0_PolicyType"" type=""IS_147"" />
      <xs:element minOccurs=""0"" name=""PTA_1_AmountClass"" type=""IS_193"" />
      <xs:element minOccurs=""0"" name=""PTA_2_MoneyOrPercentageQuantity"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""PTA_3_MoneyOrPercentage"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PTA_3_0_MoneyOrPercentageIndicator"" type=""ID_0_148"" />
            <xs:element minOccurs=""0"" name=""PTA_3_1_MoneyOrPercentageQuantity"" type=""NM_1"" />
            <xs:element minOccurs=""0"" name=""PTA_3_2_CurrencyDenomination"" type=""ID_2"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""QIP"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""QIP_0_SegmentFieldName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""QIP_1_Values"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""QSC"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""QSC_0_SegmentFieldName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""QSC_1_RelationalOperator"" type=""ID_209"" />
      <xs:element minOccurs=""0"" name=""QSC_2_Value"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""QSC_3_RelationalConjunction"" type=""ID_210"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RCD_440"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""RCD_0_SegmentFieldName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""RCD_1_Hl7DataType"" type=""ID_440"" />
      <xs:element minOccurs=""0"" name=""RCD_2_MaximumColumnWidth"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RFR"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""RFR_0_NumericRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""RFR_0_0_LowValue"" type=""NM_0"" />
            <xs:element minOccurs=""0"" name=""RFR_0_1_HighValue"" type=""NM_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""RFR_1_AdministrativeSex"" type=""IS_1"" />
      <xs:element minOccurs=""0"" name=""RFR_2_AgeRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""RFR_2_0_LowValue"" type=""NM_0"" />
            <xs:element minOccurs=""0"" name=""RFR_2_1_HighValue"" type=""NM_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""RFR_3_GestationalAgeRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""RFR_3_0_LowValue"" type=""NM_0"" />
            <xs:element minOccurs=""0"" name=""RFR_3_1_HighValue"" type=""NM_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""RFR_4_Species"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""RFR_5_RaceSubspecies"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""RFR_6_Conditions"" type=""TX"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RI"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""RI_0_RepeatPattern"" type=""IS_335"" />
      <xs:element minOccurs=""0"" name=""RI_1_ExplicitTimeInterval"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RMC"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""RMC_0_RoomType"" type=""IS_145"" />
      <xs:element minOccurs=""0"" name=""RMC_1_AmountType"" type=""IS_146"" />
      <xs:element minOccurs=""0"" name=""RMC_2_CoverageAmount"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""RMC_3_MoneyOrPercentage"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""RMC_3_0_MoneyOrPercentageIndicator"" type=""ID_0_148"" />
            <xs:element minOccurs=""0"" name=""RMC_3_1_MoneyOrPercentageQuantity"" type=""NM_1"" />
            <xs:element minOccurs=""0"" name=""RMC_3_2_CurrencyDenomination"" type=""ID_2"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RPT_335"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""RPT_0_RepeatPatternCode"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""RPT_0_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""RPT_0_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""RPT_0_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""RPT_0_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""RPT_0_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""RPT_0_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""RPT_0_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""RPT_0_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""RPT_0_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""RPT_1_CalendarAlignment"" type=""ID_527"" />
      <xs:element minOccurs=""0"" name=""RPT_2_PhaseRangeBeginValue"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""RPT_3_PhaseRangeEndValue"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""RPT_4_PeriodQuantity"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""RPT_5_PeriodUnits"" type=""IS"" />
      <xs:element minOccurs=""0"" name=""RPT_6_InstitutionSpecifiedTime"" type=""ID_136"" />
      <xs:element minOccurs=""0"" name=""RPT_7_Event"" type=""ID_528"" />
      <xs:element minOccurs=""0"" name=""RPT_8_EventOffsetQuantity"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""RPT_9_EventOffsetUnits"" type=""IS"" />
      <xs:element minOccurs=""0"" name=""RPT_10_GeneralTimingSpecification"" type=""GTS"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SCV"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""SCV_0_ParameterClass"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""SCV_0_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""SCV_0_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""SCV_0_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""SCV_0_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""SCV_0_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""SCV_0_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""SCV_0_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""SCV_0_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""SCV_0_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SCV_1_ParameterValue"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SCV_294"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""SCV_0_ParameterClass"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""SCV_0_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""SCV_0_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""SCV_0_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""SCV_0_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""SCV_0_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""SCV_0_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""SCV_0_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""SCV_0_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""SCV_0_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SCV_1_ParameterValue"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SN"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""SN_0_Comparator"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""SN_1_Num1"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""SN_2_SeparatorSuffix"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""SN_3_Num2"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SPD_337"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""SPD_0_SpecialtyName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""SPD_1_GoverningBoard"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""SPD_2_EligibleOrCertified"" type=""ID_337"" />
      <xs:element minOccurs=""0"" name=""SPD_3_DateOfCertification"" type=""DT"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SPS"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""SPS_0_SpecimenSourceNameOrCode"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""SPS_0_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""SPS_0_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""SPS_0_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""SPS_0_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""SPS_0_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""SPS_0_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""SPS_0_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""SPS_0_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""SPS_0_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SPS_1_Additives"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""SPS_1_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""SPS_1_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""SPS_1_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""SPS_1_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""SPS_1_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""SPS_1_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""SPS_1_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""SPS_1_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""SPS_1_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SPS_2_SpecimenCollectionMethod"" type=""TX"" />
      <xs:element minOccurs=""0"" name=""SPS_3_BodySite"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""SPS_3_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""SPS_3_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""SPS_3_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""SPS_3_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""SPS_3_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""SPS_3_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""SPS_3_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""SPS_3_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""SPS_3_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SPS_4_SiteModifier"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""SPS_4_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""SPS_4_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""SPS_4_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""SPS_4_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""SPS_4_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""SPS_4_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""SPS_4_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""SPS_4_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""SPS_4_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SPS_5_CollectionMethodModifierCode"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""SPS_5_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""SPS_5_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""SPS_5_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""SPS_5_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""SPS_5_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""SPS_5_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""SPS_5_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""SPS_5_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""SPS_5_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SPS_6_SpecimenRole"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""SPS_6_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""SPS_6_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""SPS_6_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""SPS_6_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""SPS_6_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""SPS_6_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""SPS_6_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""SPS_6_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""SPS_6_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SRT"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""SRT_0_SortByField"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""SRT_1_Sequencing"" type=""ID_397"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""TQ"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""TQ_0_Quantity"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""TQ_0_0_Quantity"" type=""NM_0"" />
            <xs:element minOccurs=""0"" name=""TQ_0_1_Units"" type=""CE_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TQ_1_Interval"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""TQ_1_0_RepeatPattern"" type=""IS_0_335"" />
            <xs:element minOccurs=""0"" name=""TQ_1_1_ExplicitTimeInterval"" type=""ST_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TQ_2_Duration"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""TQ_3_StartDateTime"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""TQ_3_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""TQ_3_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TQ_4_EndDateTime"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""TQ_4_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""TQ_4_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TQ_5_Priority"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""TQ_6_Condition"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""TQ_7_Text"" type=""TX"" />
      <xs:element minOccurs=""0"" name=""TQ_8_Conjunction"" type=""ID_472"" />
      <xs:element minOccurs=""0"" name=""TQ_9_OrderSequencing"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""TQ_9_0_SequenceResultsFlag"" type=""ID_0_524"" />
            <xs:element minOccurs=""0"" name=""TQ_9_1_PlacerOrderNumberEntityIdentifier"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""TQ_9_2_PlacerOrderNumberNamespaceId"" type=""IS_2_363"" />
            <xs:element minOccurs=""0"" name=""TQ_9_3_FillerOrderNumberEntityIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""TQ_9_4_FillerOrderNumberNamespaceId"" type=""IS_4_363"" />
            <xs:element minOccurs=""0"" name=""TQ_9_5_SequenceConditionValue"" type=""ST_5"" />
            <xs:element minOccurs=""0"" name=""TQ_9_6_MaximumNumberOfRepeats"" type=""NM_6"" />
            <xs:element minOccurs=""0"" name=""TQ_9_7_PlacerOrderNumberUniversalId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""TQ_9_8_PlacerOrderNumberUniversalIdType"" type=""ID_8_301"" />
            <xs:element minOccurs=""0"" name=""TQ_9_9_FillerOrderNumberUniversalId"" type=""ST_9"" />
            <xs:element minOccurs=""0"" name=""TQ_9_10_FillerOrderNumberUniversalIdType"" type=""ID_10_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TQ_10_OccurrenceDuration"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""TQ_10_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""TQ_10_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""TQ_10_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""TQ_10_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""TQ_10_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""TQ_10_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TQ_11_TotalOccurrences"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""TS"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""TS_0_Time"" type=""DTM"" />
      <xs:element minOccurs=""0"" name=""TS_1_DegreeOfPrecision"" type=""ID_529"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""UVC"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""UVC_0_ValueCode"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""UVC_0_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""UVC_0_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""UVC_0_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""UVC_0_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""UVC_0_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""UVC_0_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""UVC_0_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""UVC_0_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""UVC_0_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""UVC_1_ValueAmount"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""UVC_1_0_Quantity"" type=""NM_0"" />
            <xs:element minOccurs=""0"" name=""UVC_1_1_Denomination"" type=""ID_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""varies"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""VARIES_0_Varies"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""varies_9999"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""VARIES_0_Varies"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""VH_267"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""VH_0_StartDayRange"" type=""ID_267"" />
      <xs:element minOccurs=""0"" name=""VH_1_EndDayRange"" type=""ID_267"" />
      <xs:element minOccurs=""0"" name=""VH_2_StartHourRange"" type=""TM"" />
      <xs:element minOccurs=""0"" name=""VH_3_EndHourRange"" type=""TM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""VID"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""VID_0_VersionId"" type=""ID_104"" />
      <xs:element minOccurs=""0"" name=""VID_1_InternationalizationCode"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""VID_1_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""VID_1_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""VID_1_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""VID_1_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""VID_1_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""VID_1_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""VID_2_InternationalVersionId"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""VID_2_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""VID_2_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""VID_2_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""VID_2_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""VID_2_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""VID_2_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""VR"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""VR_0_FirstDataCodeValue"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""VR_1_LastDataCodeValue"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""XAD"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""XAD_0_StreetAddress"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XAD_0_0_StreetOrMailingAddress"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""XAD_0_1_StreetName"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XAD_0_2_DwellingNumber"" type=""ST_2"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XAD_1_OtherDesignation"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XAD_2_City"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XAD_3_StateOrProvince"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XAD_4_ZipOrPostalCode"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XAD_5_Country"" type=""ID_399"" />
      <xs:element minOccurs=""0"" name=""XAD_6_AddressType"" type=""ID_190"" />
      <xs:element minOccurs=""0"" name=""XAD_7_OtherGeographicDesignation"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XAD_8_CountyParishCode"" type=""IS_289"" />
      <xs:element minOccurs=""0"" name=""XAD_9_CensusTract"" type=""IS_288"" />
      <xs:element minOccurs=""0"" name=""XAD_10_AddressRepresentationCode"" type=""ID_465"" />
      <xs:element minOccurs=""0"" name=""XAD_11_AddressValidityRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XAD_11_0_RangeStartDateTime"" type=""TS_0"" />
            <xs:element minOccurs=""0"" name=""XAD_11_1_RangeEndDateTime"" type=""TS_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XAD_12_EffectiveDate"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XAD_12_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""XAD_12_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XAD_13_ExpirationDate"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XAD_13_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""XAD_13_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""XCN"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""XCN_0_IdNumber"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_1_FamilyName"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_1_0_Surname"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""XCN_1_1_OwnSurnamePrefix"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_1_2_OwnSurname"" type=""ST_2"" />
            <xs:element minOccurs=""0"" name=""XCN_1_3_SurnamePrefixFromPartnerSpouse"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""XCN_1_4_SurnameFromPartnerSpouse"" type=""ST_4"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_2_GivenName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_3_SecondAndFurtherGivenNamesOrInitialsThereof"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_4_SuffixEGJrOrIii"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_5_PrefixEGDr"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_6_DegreeEGMd"" type=""IS_360"" />
      <xs:element minOccurs=""0"" name=""XCN_7_SourceTable"" type=""IS_297"" />
      <xs:element minOccurs=""0"" name=""XCN_8_AssigningAuthority"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_8_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""XCN_8_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_8_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_9_NameTypeCode"" type=""ID_200"" />
      <xs:element minOccurs=""0"" name=""XCN_10_IdentifierCheckDigit"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_11_CheckDigitScheme"" type=""ID_61"" />
      <xs:element minOccurs=""0"" name=""XCN_12_IdentifierTypeCode"" type=""ID_203"" />
      <xs:element minOccurs=""0"" name=""XCN_13_AssigningFacility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_13_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""XCN_13_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_13_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_14_NameRepresentationCode"" type=""ID_465"" />
      <xs:element minOccurs=""0"" name=""XCN_15_NameContext"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_15_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""XCN_15_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_15_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""XCN_15_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""XCN_15_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""XCN_15_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_16_NameValidityRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_16_0_RangeStartDateTime"" type=""TS_0"" />
            <xs:element minOccurs=""0"" name=""XCN_16_1_RangeEndDateTime"" type=""TS_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_17_NameAssemblyOrder"" type=""ID_444"" />
      <xs:element minOccurs=""0"" name=""XCN_18_EffectiveDate"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_18_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""XCN_18_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_19_ExpirationDate"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_19_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""XCN_19_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_20_ProfessionalSuffix"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_21_AssigningJurisdiction"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_21_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""XCN_21_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_21_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""XCN_21_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""XCN_21_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""XCN_21_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""XCN_21_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""XCN_21_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""XCN_21_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_22_AssigningAgencyOrDepartment"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_22_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""XCN_22_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_22_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""XCN_22_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""XCN_22_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""XCN_22_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""XCN_22_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""XCN_22_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""XCN_22_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""XCN_10"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""XCN_0_IdNumber"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_1_FamilyName"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_1_0_Surname"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""XCN_1_1_OwnSurnamePrefix"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_1_2_OwnSurname"" type=""ST_2"" />
            <xs:element minOccurs=""0"" name=""XCN_1_3_SurnamePrefixFromPartnerSpouse"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""XCN_1_4_SurnameFromPartnerSpouse"" type=""ST_4"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_2_GivenName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_3_SecondAndFurtherGivenNamesOrInitialsThereof"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_4_SuffixEGJrOrIii"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_5_PrefixEGDr"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_6_DegreeEGMd"" type=""IS_360"" />
      <xs:element minOccurs=""0"" name=""XCN_7_SourceTable"" type=""IS_297"" />
      <xs:element minOccurs=""0"" name=""XCN_8_AssigningAuthority"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_8_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""XCN_8_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_8_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_9_NameTypeCode"" type=""ID_200"" />
      <xs:element minOccurs=""0"" name=""XCN_10_IdentifierCheckDigit"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_11_CheckDigitScheme"" type=""ID_61"" />
      <xs:element minOccurs=""0"" name=""XCN_12_IdentifierTypeCode"" type=""ID_203"" />
      <xs:element minOccurs=""0"" name=""XCN_13_AssigningFacility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_13_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""XCN_13_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_13_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_14_NameRepresentationCode"" type=""ID_465"" />
      <xs:element minOccurs=""0"" name=""XCN_15_NameContext"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_15_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""XCN_15_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_15_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""XCN_15_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""XCN_15_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""XCN_15_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_16_NameValidityRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_16_0_RangeStartDateTime"" type=""TS_0"" />
            <xs:element minOccurs=""0"" name=""XCN_16_1_RangeEndDateTime"" type=""TS_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_17_NameAssemblyOrder"" type=""ID_444"" />
      <xs:element minOccurs=""0"" name=""XCN_18_EffectiveDate"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_18_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""XCN_18_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_19_ExpirationDate"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_19_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""XCN_19_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_20_ProfessionalSuffix"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_21_AssigningJurisdiction"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_21_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""XCN_21_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_21_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""XCN_21_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""XCN_21_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""XCN_21_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""XCN_21_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""XCN_21_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""XCN_21_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_22_AssigningAgencyOrDepartment"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_22_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""XCN_22_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_22_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""XCN_22_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""XCN_22_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""XCN_22_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""XCN_22_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""XCN_22_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""XCN_22_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""XCN_84"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""XCN_0_IdNumber"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_1_FamilyName"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_1_0_Surname"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""XCN_1_1_OwnSurnamePrefix"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_1_2_OwnSurname"" type=""ST_2"" />
            <xs:element minOccurs=""0"" name=""XCN_1_3_SurnamePrefixFromPartnerSpouse"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""XCN_1_4_SurnameFromPartnerSpouse"" type=""ST_4"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_2_GivenName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_3_SecondAndFurtherGivenNamesOrInitialsThereof"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_4_SuffixEGJrOrIii"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_5_PrefixEGDr"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_6_DegreeEGMd"" type=""IS_360"" />
      <xs:element minOccurs=""0"" name=""XCN_7_SourceTable"" type=""IS_297"" />
      <xs:element minOccurs=""0"" name=""XCN_8_AssigningAuthority"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_8_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""XCN_8_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_8_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_9_NameTypeCode"" type=""ID_200"" />
      <xs:element minOccurs=""0"" name=""XCN_10_IdentifierCheckDigit"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_11_CheckDigitScheme"" type=""ID_61"" />
      <xs:element minOccurs=""0"" name=""XCN_12_IdentifierTypeCode"" type=""ID_203"" />
      <xs:element minOccurs=""0"" name=""XCN_13_AssigningFacility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_13_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""XCN_13_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_13_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_14_NameRepresentationCode"" type=""ID_465"" />
      <xs:element minOccurs=""0"" name=""XCN_15_NameContext"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_15_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""XCN_15_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_15_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""XCN_15_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""XCN_15_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""XCN_15_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_16_NameValidityRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_16_0_RangeStartDateTime"" type=""TS_0"" />
            <xs:element minOccurs=""0"" name=""XCN_16_1_RangeEndDateTime"" type=""TS_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_17_NameAssemblyOrder"" type=""ID_444"" />
      <xs:element minOccurs=""0"" name=""XCN_18_EffectiveDate"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_18_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""XCN_18_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_19_ExpirationDate"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_19_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""XCN_19_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_20_ProfessionalSuffix"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_21_AssigningJurisdiction"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_21_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""XCN_21_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_21_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""XCN_21_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""XCN_21_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""XCN_21_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""XCN_21_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""XCN_21_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""XCN_21_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_22_AssigningAgencyOrDepartment"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_22_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""XCN_22_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_22_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""XCN_22_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""XCN_22_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""XCN_22_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""XCN_22_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""XCN_22_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""XCN_22_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""XCN_188"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""XCN_0_IdNumber"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_1_FamilyName"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_1_0_Surname"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""XCN_1_1_OwnSurnamePrefix"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_1_2_OwnSurname"" type=""ST_2"" />
            <xs:element minOccurs=""0"" name=""XCN_1_3_SurnamePrefixFromPartnerSpouse"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""XCN_1_4_SurnameFromPartnerSpouse"" type=""ST_4"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_2_GivenName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_3_SecondAndFurtherGivenNamesOrInitialsThereof"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_4_SuffixEGJrOrIii"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_5_PrefixEGDr"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_6_DegreeEGMd"" type=""IS_360"" />
      <xs:element minOccurs=""0"" name=""XCN_7_SourceTable"" type=""IS_297"" />
      <xs:element minOccurs=""0"" name=""XCN_8_AssigningAuthority"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_8_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""XCN_8_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_8_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_9_NameTypeCode"" type=""ID_200"" />
      <xs:element minOccurs=""0"" name=""XCN_10_IdentifierCheckDigit"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_11_CheckDigitScheme"" type=""ID_61"" />
      <xs:element minOccurs=""0"" name=""XCN_12_IdentifierTypeCode"" type=""ID_203"" />
      <xs:element minOccurs=""0"" name=""XCN_13_AssigningFacility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_13_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""XCN_13_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_13_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_14_NameRepresentationCode"" type=""ID_465"" />
      <xs:element minOccurs=""0"" name=""XCN_15_NameContext"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_15_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""XCN_15_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_15_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""XCN_15_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""XCN_15_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""XCN_15_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_16_NameValidityRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_16_0_RangeStartDateTime"" type=""TS_0"" />
            <xs:element minOccurs=""0"" name=""XCN_16_1_RangeEndDateTime"" type=""TS_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_17_NameAssemblyOrder"" type=""ID_444"" />
      <xs:element minOccurs=""0"" name=""XCN_18_EffectiveDate"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_18_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""XCN_18_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_19_ExpirationDate"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_19_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""XCN_19_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_20_ProfessionalSuffix"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_21_AssigningJurisdiction"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_21_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""XCN_21_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_21_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""XCN_21_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""XCN_21_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""XCN_21_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""XCN_21_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""XCN_21_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""XCN_21_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_22_AssigningAgencyOrDepartment"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_22_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""XCN_22_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XCN_22_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""XCN_22_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""XCN_22_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""XCN_22_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
            <xs:element minOccurs=""0"" name=""XCN_22_6_CodingSystemVersionId"" type=""ST_6"" />
            <xs:element minOccurs=""0"" name=""XCN_22_7_AlternateCodingSystemVersionId"" type=""ST_7"" />
            <xs:element minOccurs=""0"" name=""XCN_22_8_OriginalText"" type=""ST_8"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""XON"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""XON_0_OrganizationName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XON_1_OrganizationNameTypeCode"" type=""IS_204"" />
      <xs:element minOccurs=""0"" name=""XON_2_IdNumber"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""XON_3_CheckDigit"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""XON_4_CheckDigitScheme"" type=""ID_61"" />
      <xs:element minOccurs=""0"" name=""XON_5_AssigningAuthority"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XON_5_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""XON_5_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XON_5_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XON_6_IdentifierTypeCode"" type=""ID_203"" />
      <xs:element minOccurs=""0"" name=""XON_7_AssigningFacility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XON_7_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""XON_7_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XON_7_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XON_8_NameRepresentationCode"" type=""ID_465"" />
      <xs:element minOccurs=""0"" name=""XON_9_OrganizationIdentifier"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""XPN"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""XPN_0_FamilyName"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XPN_0_0_Surname"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""XPN_0_1_OwnSurnamePrefix"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XPN_0_2_OwnSurname"" type=""ST_2"" />
            <xs:element minOccurs=""0"" name=""XPN_0_3_SurnamePrefixFromPartnerSpouse"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""XPN_0_4_SurnameFromPartnerSpouse"" type=""ST_4"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XPN_1_GivenName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XPN_2_SecondAndFurtherGivenNamesOrInitialsThereof"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XPN_3_SuffixEGJrOrIii"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XPN_4_PrefixEGDr"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XPN_5_DegreeEGMd"" type=""IS_360"" />
      <xs:element minOccurs=""0"" name=""XPN_6_NameTypeCode"" type=""ID_200"" />
      <xs:element minOccurs=""0"" name=""XPN_7_NameRepresentationCode"" type=""ID_465"" />
      <xs:element minOccurs=""0"" name=""XPN_8_NameContext"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XPN_8_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""XPN_8_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XPN_8_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""XPN_8_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""XPN_8_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""XPN_8_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XPN_9_NameValidityRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XPN_9_0_RangeStartDateTime"" type=""TS_0"" />
            <xs:element minOccurs=""0"" name=""XPN_9_1_RangeEndDateTime"" type=""TS_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XPN_10_NameAssemblyOrder"" type=""ID_444"" />
      <xs:element minOccurs=""0"" name=""XPN_11_EffectiveDate"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XPN_11_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""XPN_11_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XPN_12_ExpirationDate"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XPN_12_0_Time"" type=""DTM_0"" />
            <xs:element minOccurs=""0"" name=""XPN_12_1_DegreeOfPrecision"" type=""ID_1_529"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XPN_13_ProfessionalSuffix"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""XTN"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""XTN_0_TelephoneNumber"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XTN_1_TelecommunicationUseCode"" type=""ID_201"" />
      <xs:element minOccurs=""0"" name=""XTN_2_TelecommunicationEquipmentType"" type=""ID_202"" />
      <xs:element minOccurs=""0"" name=""XTN_3_EmailAddress"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XTN_4_CountryCode"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""XTN_5_AreaCityCode"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""XTN_6_LocalNumber"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""XTN_7_Extension"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""XTN_8_AnyText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XTN_9_ExtensionPrefix"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XTN_10_SpeedDialCode"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XTN_11_UnformattedTelephoneNumber"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        public datatypes_251() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "HL7DefinedDataTypes";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
