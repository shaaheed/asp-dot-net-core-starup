import { Component } from '@angular/core';
import { FormControl } from '@angular/forms';
import { of } from 'rxjs';
import { FormComponent } from 'src/app/shared/form.component';
import { ActivatedRoute } from '@angular/router';
import { CustomerService } from 'src/services/customer.service';

@Component({
  selector: 'app-customers-add',
  templateUrl: './customers-add.component.html'
})
export class CustomersAddComponent extends FormComponent {

  loading: boolean = false;
  noData: boolean = false;

  constructor(
    private customerService: CustomerService,
    private activatedRoute: ActivatedRoute
  ) {
    super();
  }

  ngOnInit(): void {
    this.createForm({
      name: [null, [], this.customerNameValidator.bind(this)],
      email: [],
      mobile: [],
      contact: []
    });

    super.ngOnInit(this.activatedRoute.snapshot);
  }

  customerNameValidator(control: FormControl) {
    if (!control.value) {
      return this.error('please.give.a.name');
    }
    else if (control.value.length < 3) {
      return this.error('name.must.be.greater.than.3.letters');
    }
    return of(true);
  }

}
