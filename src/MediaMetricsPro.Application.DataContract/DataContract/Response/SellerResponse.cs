namespace MediaMetricsPro.Application.DataContract.DataContract.Response;

public record SellerResponse(string name, AddressResponse address) { }
public record AddressResponse(string street, int number, string district, string city, StateResponse state, CountryResponse country) { }
public record StateResponse(short id, string nome) { }
public record CountryResponse(short id, string nome) { }