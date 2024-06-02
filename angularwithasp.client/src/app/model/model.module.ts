import { NgModule } from "@angular/core";
import { ProductRepository } from "./product.repository";
import { Cart } from "./cart.model";
import { Order } from "./order.model";
import { Bag } from "./bag.model";
import { OrderRepository } from "./order.repository";
import { HttpClientModule } from "@angular/common/http";

@NgModule({
    imports: [HttpClientModule],
  providers: [ProductRepository, Cart, Order, Bag, OrderRepository]
})
export class ModelModule { }
