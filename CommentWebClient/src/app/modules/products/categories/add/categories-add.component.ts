import { Component } from '@angular/core';
import { FormComponent } from 'src/app/shared/form.component';
import { ActivatedRoute } from '@angular/router';
import { ValidatorService } from 'src/services/validator.service';

@Component({
  selector: 'app-categories-add',
  templateUrl: './categories-add.component.html'
})
export class CategoriesAddComponent extends FormComponent {

  loading: boolean = false;
  noData: boolean = false;
  url = 'products/categories';
  cancelRoute = 'products/categories';
  addTitle = 'create.a.x0|{"x0":"product.category"}';
  editTitle = 'update.a.x0|{"x0":"product.category"}';

  constructor(
    private activatedRoute: ActivatedRoute,
    private validator: ValidatorService
  ) {
    super();
  }

  ngOnInit(): void {
    this.createForm({
      name: [null, [], [
        this.validator.required().bind(this),
        this.validator.min(2).bind(this)
      ]],
    });
    super.ngOnInit(this.activatedRoute.snapshot);
  }
}
