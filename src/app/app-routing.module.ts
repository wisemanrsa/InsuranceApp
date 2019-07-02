import { PremiumManagerComponent } from './components/premium-manager/premium-manager.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'premium',
    pathMatch: 'full'
  },
  {
    path: 'premium',
    component: PremiumManagerComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
