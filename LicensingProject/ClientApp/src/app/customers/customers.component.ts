import { Component, OnDestroy, OnInit } from '@angular/core';
import { Observable, Subscription } from 'rxjs';
import { Customer } from '../models/customer.model';
import { CustomersService } from '../services/customers.service';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent implements OnInit, OnDestroy {


  customers!: Observable<Customer[]>;
  deleteSubscription!: Subscription;
  constructor(private customersService: CustomersService) { }

  ngOnInit(): void {
      this.customers = this.customersService.getCustomers();
  }
  ngOnDestroy(): void {
    this.deleteSubscription?.unsubscribe();
  }

  deleteCustomer(id: string)
  {
      this.deleteSubscription?.unsubscribe();
      this.deleteSubscription = this.customersService.deleteCustomer(id)
                            .subscribe(()=>{
                              this.customers = this.customersService.getCustomers();
                            }, error=>{});
  }
}
