export class License{
    id!:	string;
    info!:	string;
    licenseType!:	string
    startDate: Date = new Date();
    numberOfDays:	number = 0;
    isTrial:	boolean = false;
}