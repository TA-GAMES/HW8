<div dir='rtl' lang='he'>
  
  קישור למשחק : https://talabed.itch.io/tilesmapgame
  
  במטלה השבועית בחרתי לענות על סעיפים ד' + ה'.
  
  ## סעיף ד'
  שיניתי את הסקריפטים CaveGenerator וTileMapCaveGenerator.
  * CaveGenerator : בפונקציות RandomizeMap וSmoothMap הוספתי שבמקרה בו לא צריך להיות קיר, אלא משבצת שמותר לדרוך עליה, תהיה בחירה רנדומלית בין 0 לבין 2, ששתיהם מייצגים משבצת חוקית. לאחר מכן משבצות עם 0 בהן ייצגו סוג אריח אחד ומשבצות עם 2 בהן ייצגו אריח מסוג אחר (על שני הסוגים יהיה מותר לדרוך).
  * TileMapCavegenerator : הוספתי למעצב סוג משבצת נוספת שהוא צריך לטעון שמותר לדרוך עליה. בפונקציה GenerateAndDisplayTexture, במשבצות עליהן מותר לדרוך ייבחר אריח לפי מה ששמור במשבצת (0 או 2). באופן זה תיווצר באופן רנדומלי מפה עם 3 סוגי אריחים.
  
  ## סעיף ה'
  שיניתי את הסקריפט KeyboardMoverByTile.
  הוספתי 2 סוגי משבצות שהמעצב צריך לציין כאשר הוא משתמש בסקריפט : tileSweepTo המייצגת את האריח אליו הוא רוצה להחליף וtileSweepFrom שמייצג את האריח אותו אתה רוצה לשנות.
  בפונקציה update הוספתי תנאי if לפיו אם השחקן מנסה לדרוך במשבצת שהוא לא יכול לדרוך עליה, שימוש במקש "רווח" ולאחר מכן לחיצה על הכיוון אליו הוא רוצה ללכת יחליף את המשבצת שאסור לדרוך עליה במשבצת שמותר. במשחק שלי אריח של הר יהפוך לאריח של דשא.
  
  
  </div>
