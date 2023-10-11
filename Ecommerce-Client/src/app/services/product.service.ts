import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../environment/environment';
import { Product } from '../response_model/Product';

@Injectable({
  providedIn: 'root',
})
export class ProductService {
  private baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getAllProducts() {
    return this.http.get<Product[]>(this.baseUrl + 'Product');
  }
  addCartService(cart: any) {
    return this.http.post(this.baseUrl + 'Cart', JSON.stringify(cart));
  }
}
