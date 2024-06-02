import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Order } from "./order.model";
import { HttpClient } from '@angular/common/http';
import { Bag } from "./bag.model";

@Injectable()
export class OrderRepository {
  private orders: Order[] = [];
  constructor(private http: HttpClient) {
  }

  getOrders(): Order[] {
        return this.orders;
    }
  saveOrder(order: Order): Observable<Order> {
    return this.http.post<Order>('./order', order);
  }
  saveBag(bag: Bag): Observable<Bag> {
    return this.http.post<Bag>('./cartline', bag);
  }
}
