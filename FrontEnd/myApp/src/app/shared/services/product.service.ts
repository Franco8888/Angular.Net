import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Product } from '../models/product.model';

@Injectable({
  providedIn: 'root'
})
export class ProductService {  

  BASEURL = "https://localhost:7250/api/test/product/";

  constructor(
    private http: HttpClient,
  ) { }

  getProducts(): Promise<Product[]> {
    return this.http.post<Product[]>(`${this.BASEURL}getproducts`, {}).toPromise();
  }

  addProducts(product: Product): Promise<boolean> {
    return this.http.post<boolean>(`${this.BASEURL}addproduct`, product).toPromise();
  }

}
