import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { PremiumsService } from 'src/app/services/premiums.service';
import { InsuredValueInterface } from 'src/app/models/insured-values.interface';
import { PremiumInterface } from 'src/app/models/premim.interface';
import * as moment from 'moment';

@Component({
  selector: 'app-premium-calculator',
  templateUrl: './premium-calculator.component.html',
  styleUrls: ['./premium-calculator.component.scss']
})
export class PremiumCalculatorComponent implements OnInit {

  constructor(private premiumsService: PremiumsService) { }
  insuredValues: InsuredValueInterface[];
  allInsuredValues: InsuredValueInterface[];
  errMessage = '';

  @Output()
  finalPremium: EventEmitter<PremiumInterface> = new EventEmitter<PremiumInterface>();

  ngOnInit() {
    this.premiumsService.getInsuredValues().subscribe((values: InsuredValueInterface[]) => {
      this.allInsuredValues = values;
      this.insuredValues = this.allInsuredValues.filter(val => !val.isMember);
    });
  }

  calculatePremiums(formValues) {
    const first6Digits = formValues.pid.toString().substring(0, 6);
    // tslint:disable-next-line: radix
    const dateOfBirth = first6Digits.match(/.{1,2}/g).join('-');
    if (!moment(moment(dateOfBirth).format('YY-MM-DD')).isValid()) {
      this.errMessage = 'Cannot extract age from payer ID';
      return;
    }
    console.log(dateOfBirth);
    const age = new Date().getFullYear() - new Date(moment(dateOfBirth).format('YY-MM-DD')).getFullYear();
    const obj = {
      age,
      sumIsuredId: formValues.sumInsured,
      isMember: formValues.mid.toString().length > 0,
      payerId: formValues.pid,
      payerName: formValues.fname
    };
    this.premiumsService.calculatePremium(obj).subscribe((res: PremiumInterface) => {
      this.finalPremium.emit(res);
      this.errMessage = '';
    }, (err) => this.errMessage = err.error);
  }

  filterSumValues(field) {
    console.log(field);
    this.insuredValues = this.allInsuredValues.filter(i => i.isMember === field.length > 0);
  }
}
