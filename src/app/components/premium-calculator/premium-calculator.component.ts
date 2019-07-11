import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { PremiumsService } from 'src/app/services/premiums.service';
import { InsuredValueInterface } from 'src/app/models/insured-values.interface';
import { PremiumInterface } from 'src/app/models/premim.interface';

@Component({
  selector: 'app-premium-calculator',
  templateUrl: './premium-calculator.component.html',
  styleUrls: ['./premium-calculator.component.scss']
})
export class PremiumCalculatorComponent implements OnInit {

  constructor(private premiumsService: PremiumsService) { }
  insuredValues: InsuredValueInterface[];
  allInsuredValues: InsuredValueInterface[];

  @Output()
  finalPremium: EventEmitter<PremiumInterface> = new EventEmitter<PremiumInterface>();

  ngOnInit() {
    this.premiumsService.getInsuredValues().subscribe((values: InsuredValueInterface[]) => {
      this.allInsuredValues = values;
      this.insuredValues = this.allInsuredValues.filter(val => !val.isMember);
    });
  }

  calculatePremiums(formValues) {
    const pidStr = formValues.pid.toString();
// tslint:disable-next-line: radix
    const year = pidStr.startsWith('0') ? parseInt(`20${pidStr.substring(0, 2)}`) : parseInt(`19${pidStr.substring(0, 2)}`);
    const age = new Date().getFullYear() - year;
    const obj = {
      age,
      sumIsuredId: formValues.sumInsured,
      isMember: formValues.mid.toString().length > 0
    };
    this.premiumsService.calculatePremium(obj).subscribe((res: PremiumInterface) => this.finalPremium.emit(res));
  }

}
