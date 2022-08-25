import { License } from "./license.model";
import { Product } from "./product.model";

export class LicenseProduct{
    id!: string;
    licenses!: License[];
    product!: Product;
}