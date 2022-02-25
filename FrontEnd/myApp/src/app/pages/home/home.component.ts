import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/shared/models/product.model';
import { ProductService } from 'src/app/shared/services/product.service';

@Component({
  selector: 'home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  products: Product[] = [];

  constructor(
    private productService: ProductService
    ) {}

  async ngOnInit() {
    const result = await this.productService.getProducts();

    this.products = result;

    const addResult = await this.productService.addProducts(this.products[0]);

  }

}
