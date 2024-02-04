class Solution {
    public boolean isAnagram(String s, String t) {
        Boolean result = true;

        if(s.length() != t.length()) { 
            return false;
        }

        HashMap<Character, Integer> mapS = new HashMap<>();
        HashMap<Character, Integer> mapT = new HashMap<>();

        for(int i = 0; i <= s.length() - 1; i++) {
           if(mapS.containsKey(s.charAt(i))) {
                mapS.put(s.charAt(i), mapS.get(s.charAt(i))+1);
            } else {
                mapS.put(s.charAt(i), 1);
            } 
        }

        for(int i = 0; i <= t.length() - 1; i++) {
            if(mapT.containsKey(t.charAt(i))) {
                mapT.put(t.charAt(i), mapT.get(t.charAt(i))+1);
            } else {
                mapT.put(t.charAt(i), 1);
            }
        }

        for(Character c : mapS.keySet()) {
            if(!mapS.get(c).equals(mapT.get(c))) {
                result = false;
            }
        }

        return result;
    }
}