import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductComponent } from './product/product/product.component';
import { CartComponent } from './cart/cart/cart.component';
import { HomeComponent } from './root/home/home.component';

const routes: Routes = [
  { path: '**', pathMatch: 'full', component: HomeComponent },
  { path: 'product_detail', component: ProductComponent },
  { path: 'cart', component: CartComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
