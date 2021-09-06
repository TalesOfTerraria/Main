using System.Collections.Generic;
using Terraria.ModLoader;

namespace ToT.DamageClasses
{
	public class AdvancementDamage : DamageClass
	{
		public override void SetStaticDefaults() {
			// Make weapons with this damage type have a tooltip of 'X example damage'.
			ClassName.SetDefault("Advancement damage");
		}

		protected override float GetBenefitFrom(DamageClass damageClass) {
			// Make this damage class not benefit from any otherclass stat bonuses by default, but still benefit from universal/all-class bonuses.
			if (damageClass == DamageClass.Generic)
				return 1f;

			return 0;
		}

		public override bool CountsAs(DamageClass damageClass) {

			return false;
		}
	}
}