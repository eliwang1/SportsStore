import { Component } from "@angular/core";
import { NgForm } from "@angular/forms";
import { OrderRepository } from "../model/order.repository";
import { Order } from "../model/order.model";
import { Bag } from "../model/bag.model";

@Component({
    templateUrl: "checkout.component.html",
    styleUrls: ["checkout.component.css"]
})
export class CheckoutComponent {
    orderSent: boolean = false;
    submitted: boolean = false;

  constructor(public repository: OrderRepository,
                public order: Order, public bag: Bag) {}

  submitOrder(form: NgForm) {
        this.submitted = true;
      if (form.valid) {
        let i = 0;
        while (i < this.order.cart.lines.length) {
          this.bag.quantity = this.order.cart.lines[i].quantity;
          this.bag.productid = this.order.cart.lines[i].product.id;
          this.bag.orderid = 0;
          this.order.bags.push(this.bag);
        this.repository.saveBag(this.bag).subscribe(bag => { });
        i++;
        }
        this.repository.saveOrder(this.order).subscribe(order => { });
                this.order.clear();
                this.orderSent = true;
                this.submitted = false;
            };
        }
    }

