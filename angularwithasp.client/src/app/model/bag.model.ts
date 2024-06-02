import { Injectable } from "@angular/core";
@Injectable()
export class Bag {

  public cartlineid?: number;
  public productid?: number;
  public quantity?: number;
  public orderid?: number;
  constructor() { }
}
