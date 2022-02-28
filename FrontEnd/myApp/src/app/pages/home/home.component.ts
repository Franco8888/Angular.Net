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

    const product = new Product('2323', 'Timmy', 900,  'Timmaaaaah', 10);
    
    const addResult = await this.productService.addProducts(product);

    if(addResult) {
      const result = await this.productService.getProducts();
      this.products = result;
    }
    
    var promise = new Promise(() => {
      //Do Something
    });

  }

}
