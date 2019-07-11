import { Component, OnInit } from '@angular/core';
import { PremiumsService } from 'src/app/services/premiums.service';
import { InsuredValueInterface } from 'src/app/models/insured-values.interface';

@Component({
  selector: 'app-premium-calculator',
  templateUrl: './premium-calculator.component.html',
  styleUrls: ['./premium-calculator.component.scss']
})
export class PremiumCalculatorComponent implements OnInit {

  constructor(private premiumsService: PremiumsService) { }
  insuredValues: InsuredValueInterface[];
  allInsuredValues: InsuredValueInterface[];

  ngOnInit() {
    this.premiumsService.getInsuredValues().subscribe((values: InsuredValueInterface[]) => {
      this.allInsuredValues = values;
      this.insuredValues = this.allInsuredValues.filter(val => !val.isMember);
    });
  }

  calculatePremiums(formValues) {
    console.log(formValues);
  }

}
