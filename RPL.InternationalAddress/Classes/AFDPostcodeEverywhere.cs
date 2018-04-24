using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace RPL.InternationalAddress.Classes
{
    /// <summary>
    /// AFD Postcode Everywhere XML
    /// </summary>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class AFDPostcodeEverywhere
    {
        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public int Result { get; set; }

        /// <summary>
        /// Gets or sets the error text.
        /// </summary>
        /// <value>
        /// The error text.
        /// </value>
        public string ErrorText { get; set; }

        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        /// <value>
        /// The item.
        /// </value>
        [XmlElement("Item")]
        public AFDPostcodeEverywhereItem[] Item { get; set; }
    }

    /// <summary>
    /// AFD Postcode Everywhere XML Item/Record
    /// </summary>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class AFDPostcodeEverywhereItem
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [XmlAttribute]
        public byte value { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the organisation.
        /// </summary>
        /// <value>
        /// The organisation.
        /// </value>
        public string Organisation { get; set; }

        /// <summary>
        /// Gets or sets the property.
        /// </summary>
        /// <value>
        /// The property.
        /// </value>
        public string Property { get; set; }

        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        /// <value>
        /// The street.
        /// </value>
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the locality.
        /// </summary>
        /// <value>
        /// The locality.
        /// </value>
        public string Locality { get; set; }

        /// <summary>
        /// Gets or sets the town.
        /// </summary>
        /// <value>
        /// The town.
        /// </value>
        public string Town { get; set; }

        /// <summary>
        /// Gets or sets the postal county.
        /// </summary>
        /// <value>
        /// The postal county.
        /// </value>
        public string PostalCounty { get; set; }

        /// <summary>
        /// Gets or sets the abbreviated postal county.
        /// </summary>
        /// <value>
        /// The abbreviated postal county.
        /// </value>
        public string AbbreviatedPostalCounty { get; set; }

        /// <summary>
        /// Gets or sets the optional county.
        /// </summary>
        /// <value>
        /// The optional county.
        /// </value>
        public string OptionalCounty { get; set; }

        /// <summary>
        /// Gets or sets the abbreviated optional county.
        /// </summary>
        /// <value>
        /// The abbreviated optional county.
        /// </value>
        public string AbbreviatedOptionalCounty { get; set; }

        /// <summary>
        /// Gets or sets the traditional county.
        /// </summary>
        /// <value>
        /// The traditional county.
        /// </value>
        public string TraditionalCounty { get; set; }

        /// <summary>
        /// Gets or sets the administrative county.
        /// </summary>
        /// <value>
        /// The administrative county.
        /// </value>
        public string AdministrativeCounty { get; set; }

        /// <summary>
        /// Gets or sets the postcode.
        /// </summary>
        /// <value>
        /// The postcode.
        /// </value>
        public string Postcode { get; set; }

        /// <summary>
        /// Gets or sets the DPS.
        /// </summary>
        /// <value>
        /// The DPS.
        /// </value>
        public string DPS { get; set; }

        /// <summary>
        /// Gets or sets the postcode from.
        /// </summary>
        /// <value>
        /// The postcode from.
        /// </value>
        public string PostcodeFrom { get; set; }

        /// <summary>
        /// Gets or sets the type of the postcode.
        /// </summary>
        /// <value>
        /// The type of the postcode.
        /// </value>
        public string PostcodeType { get; set; }

        /// <summary>
        /// Gets or sets the mailsort code.
        /// </summary>
        /// <value>
        /// The mailsort code.
        /// </value>
        public string MailsortCode { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the grid e.
        /// </summary>
        /// <value>
        /// The grid e.
        /// </value>
        public string GridE { get; set; }

        /// <summary>
        /// Gets or sets the grid n.
        /// </summary>
        /// <value>
        /// The grid n.
        /// </value>
        public string GridN { get; set; }

        /// <summary>
        /// Gets or sets the miles.
        /// </summary>
        /// <value>
        /// The miles.
        /// </value>
        public string Miles { get; set; }

        /// <summary>
        /// Gets or sets the km.
        /// </summary>
        /// <value>
        /// The km.
        /// </value>
        public string Km { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        /// <value>
        /// The latitude.
        /// </value>
        public string Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        /// <value>
        /// The longitude.
        /// </value>
        public string Longitude { get; set; }

        /// <summary>
        /// Gets or sets the just built.
        /// </summary>
        /// <value>
        /// The just built.
        /// </value>
        public string JustBuilt { get; set; }

        /// <summary>
        /// Gets or sets the urban rural code.
        /// </summary>
        /// <value>
        /// The urban rural code.
        /// </value>
        public string UrbanRuralCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the urban rural.
        /// </summary>
        /// <value>
        /// The name of the urban rural.
        /// </value>
        public string UrbanRuralName { get; set; }

        /// <summary>
        /// Gets or sets the ward code.
        /// </summary>
        /// <value>
        /// The ward code.
        /// </value>
        public string WardCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the ward.
        /// </summary>
        /// <value>
        /// The name of the ward.
        /// </value>
        public string WardName { get; set; }

        /// <summary>
        /// Gets or sets the constituency code.
        /// </summary>
        /// <value>
        /// The constituency code.
        /// </value>
        public string ConstituencyCode { get; set; }

        /// <summary>
        /// Gets or sets the constituency.
        /// </summary>
        /// <value>
        /// The constituency.
        /// </value>
        public string Constituency { get; set; }

        /// <summary>
        /// Gets or sets the eer code.
        /// </summary>
        /// <value>
        /// The eer code.
        /// </value>
        public string EERCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the eer.
        /// </summary>
        /// <value>
        /// The name of the eer.
        /// </value>
        public string EERName { get; set; }

        /// <summary>
        /// Gets or sets the authority code.
        /// </summary>
        /// <value>
        /// The authority code.
        /// </value>
        public string AuthorityCode { get; set; }

        /// <summary>
        /// Gets or sets the authority.
        /// </summary>
        /// <value>
        /// The authority.
        /// </value>
        public string Authority { get; set; }

        /// <summary>
        /// Gets or sets the lea code.
        /// </summary>
        /// <value>
        /// The lea code.
        /// </value>
        public string LEACode { get; set; }

        /// <summary>
        /// Gets or sets the name of the lea.
        /// </summary>
        /// <value>
        /// The name of the lea.
        /// </value>
        public string LEAName { get; set; }

        /// <summary>
        /// Gets or sets the tv region.
        /// </summary>
        /// <value>
        /// The tv region.
        /// </value>
        public string TVRegion { get; set; }

        /// <summary>
        /// Gets or sets the occupancy.
        /// </summary>
        /// <value>
        /// The occupancy.
        /// </value>
        public string Occupancy { get; set; }

        /// <summary>
        /// Gets or sets the occupancy description.
        /// </summary>
        /// <value>
        /// The occupancy description.
        /// </value>
        public string OccupancyDescription { get; set; }

        /// <summary>
        /// Gets or sets the type of the address.
        /// </summary>
        /// <value>
        /// The type of the address.
        /// </value>
        public string AddressType { get; set; }

        /// <summary>
        /// Gets or sets the address type description.
        /// </summary>
        /// <value>
        /// The address type description.
        /// </value>
        public string AddressTypeDescription { get; set; }

        /// <summary>
        /// Gets or sets the udprn.
        /// </summary>
        /// <value>
        /// The udprn.
        /// </value>
        public string UDPRN { get; set; }

        /// <summary>
        /// Gets or sets the uprn.
        /// </summary>
        /// <value>
        /// The uprn.
        /// </value>
        public string UPRN { get; set; }

        /// <summary>
        /// Gets or sets the NHS code.
        /// </summary>
        /// <value>
        /// The NHS code.
        /// </value>
        public string NHSCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the NHS.
        /// </summary>
        /// <value>
        /// The name of the NHS.
        /// </value>
        public string NHSName { get; set; }

        /// <summary>
        /// Gets or sets the NHS region code.
        /// </summary>
        /// <value>
        /// The NHS region code.
        /// </value>
        public string NHSRegionCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the NHS region.
        /// </summary>
        /// <value>
        /// The name of the NHS region.
        /// </value>
        public string NHSRegionName { get; set; }

        /// <summary>
        /// Gets or sets the PCT code.
        /// </summary>
        /// <value>
        /// The PCT code.
        /// </value>
        public string PCTCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the PCT.
        /// </summary>
        /// <value>
        /// The name of the PCT.
        /// </value>
        public string PCTName { get; set; }

        /// <summary>
        /// Gets or sets the name of the sub country.
        /// </summary>
        /// <value>
        /// The name of the sub country.
        /// </value>
        public string SubCountryName { get; set; }

        /// <summary>
        /// Gets or sets the devolved constituency code.
        /// </summary>
        /// <value>
        /// The devolved constituency code.
        /// </value>
        public string DevolvedConstituencyCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the devolved constituency.
        /// </summary>
        /// <value>
        /// The name of the devolved constituency.
        /// </value>
        public string DevolvedConstituencyName { get; set; }

        /// <summary>
        /// Gets or sets the censation code.
        /// </summary>
        /// <value>
        /// The censation code.
        /// </value>
        public string CensationCode { get; set; }

        /// <summary>
        /// Gets or sets the censation label.
        /// </summary>
        /// <value>
        /// The censation label.
        /// </value>
        public string CensationLabel { get; set; }

        /// <summary>
        /// Gets or sets the affluence.
        /// </summary>
        /// <value>
        /// The affluence.
        /// </value>
        public string Affluence { get; set; }

        /// <summary>
        /// Gets or sets the lifestage.
        /// </summary>
        /// <value>
        /// The lifestage.
        /// </value>
        public string Lifestage { get; set; }

        /// <summary>
        /// Gets or sets the additional census information.
        /// </summary>
        /// <value>
        /// The additional census information.
        /// </value>
        public string AdditionalCensusInfo { get; set; }

        /// <summary>
        /// Gets or sets the soa lower.
        /// </summary>
        /// <value>
        /// The soa lower.
        /// </value>
        public string SOALower { get; set; }

        /// <summary>
        /// Gets or sets the soa middle.
        /// </summary>
        /// <value>
        /// The soa middle.
        /// </value>
        public string SOAMiddle { get; set; }

        /// <summary>
        /// Gets or sets the residency.
        /// </summary>
        /// <value>
        /// The residency.
        /// </value>
        public string Residency { get; set; }

        /// <summary>
        /// Gets or sets the household composition.
        /// </summary>
        /// <value>
        /// The household composition.
        /// </value>
        public string HouseholdComposition { get; set; }

        /// <summary>
        /// Gets or sets the business.
        /// </summary>
        /// <value>
        /// The business.
        /// </value>
        public string Business { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public string Size { get; set; }

        /// <summary>
        /// Gets or sets the sic code.
        /// </summary>
        /// <value>
        /// The sic code.
        /// </value>
        public string SICCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the location.
        /// </summary>
        /// <value>
        /// The type of the location.
        /// </value>
        public string LocationType { get; set; }

        /// <summary>
        /// Gets or sets the branch count.
        /// </summary>
        /// <value>
        /// The branch count.
        /// </value>
        public string BranchCount { get; set; }

        /// <summary>
        /// Gets or sets the group identifier.
        /// </summary>
        /// <value>
        /// The group identifier.
        /// </value>
        public string GroupID { get; set; }

        /// <summary>
        /// Gets or sets the modelled turnover.
        /// </summary>
        /// <value>
        /// The modelled turnover.
        /// </value>
        public string ModelledTurnover { get; set; }

        /// <summary>
        /// Gets or sets the size of the national.
        /// </summary>
        /// <value>
        /// The size of the national.
        /// </value>
        public string NationalSize { get; set; }

        /// <summary>
        /// Gets or sets the on edited roll.
        /// </summary>
        /// <value>
        /// The on edited roll.
        /// </value>
        public string OnEditedRoll { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the forename.
        /// </summary>
        /// <value>
        /// The forename.
        /// </value>
        public string Forename { get; set; }

        /// <summary>
        /// Gets or sets the middle initial.
        /// </summary>
        /// <value>
        /// The middle initial.
        /// </value>
        public string MiddleInitial { get; set; }

        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        /// <value>
        /// The surname.
        /// </value>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        /// <value>
        /// The date of birth.
        /// </value>
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the council tax band.
        /// </summary>
        /// <value>
        /// The council tax band.
        /// </value>
        public string CouncilTaxBand { get; set; }

        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        /// <value>
        /// The product.
        /// </value>
        public string Product { get; set; }

        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        /// <value>
        /// The key.
        /// </value>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the list.
        /// </summary>
        /// <value>
        /// The list.
        /// </value>
        public string List { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the country iso.
        /// </summary>
        /// <value>
        /// The country iso.
        /// </value>
        public string CountryISO { get; set; }

        /// <summary>
        /// Gets or sets the multiple residency indicator.
        /// </summary>
        /// <value>
        /// The multiple residency indicator.
        /// </value>
        public string MultipleResidencyIndicator { get; set; }
    }
}
