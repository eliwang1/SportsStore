import { Inject, Injectable } from "@angular/core";
import { Product } from "./product.model";
import { HttpClient } from '@angular/common/http';
// import { StaticDataSource } from "./static.datasource";

@Injectable()
export class ProductRepository {
    private products: Product[] = [];
    private categories: string[] = [];

  
  constructor(http: HttpClient ) {
    http.get<Product[]>('./home').subscribe(result => {
      this.products = result;
    }, error => console.error(error));
  }

    getProducts(category?: string): Product[] {
        return this.products
            .filter(p => category == undefined || category == p.category);
    }

    getProduct(id: number): Product | undefined {
        return this.products.find(p => p.id == id);
    }

    getCategories(): string[] {
        return this.categories;
    }
}
