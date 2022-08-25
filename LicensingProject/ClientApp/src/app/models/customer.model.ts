import { LicenseProduct } from "./license-product.model";

export class Customer{
    id!: string;
    address!: string;
    name!: string;
    phone!: string;
    licensedProducts!: LicenseProduct[] ;
}