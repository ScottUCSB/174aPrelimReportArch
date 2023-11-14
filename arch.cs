class CustomerProfile{
    attributes: UserName(String), Password(String), Name(String), StateCode(String), PhoneNumber(int), Email(String), TaxID(int);
    method makeAccount(AccountType, deposit) -> Account;
    method login(UserName, Password) -> boolean;
    method updateProfile(details);
    method viewAccounts() -> List<Account>;
}

class Account {
    attributes: AccountIDNumber(int), ListTransactions(List<Transaction>), Balance(float), AccountType(String), OpeningDate(Date), UserName(String);
    method executeTransaction(Transaction) -> void;
    method viewTransactions() -> List<Transaction>;
    method getBalance() -> float;
}
class Transaction {
    attributes: TransactionID(int), AccountIDNumber(int), TransactionType(String), AmountAndFees(float), TransactionDate(Date), StockSymbol(String);
    method deposit() -> void;
    method withdraw() -> void;
    method buy() -> void;
    method sell() -> void;
    method accrueIntrestManagerOnly() -> void;  //NOTE:special priv req
    method execute() -> void;
    method cancel() -> void;
}
class Stock {
    attributes: StockSymbol(String), DailyClosingPrices(List<Float>), CurrentPrice(float), ActorDirectorName(String);
    method updatePrice(newPrice) -> void;
    method getPastPrices() -> List<Float>;
    method getAssociatedActorDirector() -> ActorDirector;
}

class ActorDirectorProfile {
    attributes: ActorDirectorName(String), StockSymbol(String), DateOfBirth(Date), ActingDirAwards(List<String>), Films(List<String>), Reviews(List<String>);
    method getFilmList() -> List<String>;
    method getAwards() -> List<String>;
    method getReviews() -> List<String>;
    method getBoxOfficeSales() -> List<String>;
    //NOTE: OR Box Office Sales can be summed with a query if needed/instead.
}

class Contract {
    attributes: Title(String), Year(int), Role(String), Pay(float);
    //NOTE:can ActorDirectorName be omitted since it's a weak entity, and its relationship can be managed through queries?
    method getContractDetails() -> String;
}

class Movie {
    attributes: Title(String), Year(int), Reviews(List<String>), Rating(float), BoxOfficeSales(float), FilmAwards(List<String>);
    method getReviews() -> List<String>;
    method updateRating(newRating) -> void;
    method updateBoxOfficeSales(newSales) -> void;
}
