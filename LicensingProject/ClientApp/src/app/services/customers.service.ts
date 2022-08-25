import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment.prod';
import { Customer } from '../models/customer.model';


@Injectable({
  providedIn: 'root'
})
export class CustomersService {
  apiBase: string;
  constructor(private httpClient: HttpClient) 
  {
     this.apiBase = environment.apiBase;
  }

  public getCustomers(): Observable<Customer[]>
  {
      let apiUrl = `${this.apiBase}customers`;
      return this.httpClient.get<Customer[]>(apiUrl);
  }
  public createCustomer(name: string, address: string, phone: string): Observable<Customer>
  {
    let apiUrl = `${this.apiBase}customers`;
      let customer  = {
          name: name,
          address: address,
          phone: phone      
      };
      return this.httpClient.post<Customer>(apiUrl, customer);
  }

  public getCustomerById(id: string): Observable<Customer>
  {
    let apiUrl = `${this.apiBase}customers/${id}`;
    return this.httpClient.get<Customer>(apiUrl);
  }

  public updateCustomer(id:string, name: string, address: string, phone: string): Observable<Customer>
  {
    let apiUrl = `${this.apiBase}customers/${id}`;
      let customer  = {
          id: id,
          name: name,
          address: address,
          phone: phone      
      };
      return this.httpClient.put<Customer>(apiUrl, customer);
  }

  public deleteCustomer(id: string): Observable<any>
  {
    let apiUrl = `${this.apiBase}customers/${id}`;
    return this.httpClient.delete(apiUrl);
  }


}
